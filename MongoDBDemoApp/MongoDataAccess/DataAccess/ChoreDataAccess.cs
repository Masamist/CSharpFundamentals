using MongoDataAccess.Models;
using MongoDB.Driver;

namespace MongoDataAccess.DataAccess
{
    public class ChoreDataAccess
    {
        private const string ConnectionString = "mongodb+srv://msmk0304:sx6WVCdhBuWW8qFY@cluster0.t7xlyly.mongodb.net/?retryWrites=true&w=majority";
        private const string DatabaseName = "choreDB";
        private const string ChoreCollection = "chore_chart";
        private const string UserCollection = "users";
        private const string ChoreHistoryCollection = "chore_history";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var results = await usersCollection.FindAsync( _ => true);
            return results.ToList();
        }

        public async Task<List<ChoreModel>> GetAllChores()
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            var results = await choresCollection.FindAsync( _ => true);
            return results.ToList();
        }

        public async Task<List<ChoreModel>> GetAllChoresForAUser(UserModel user)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            var results = await choresCollection.FindAsync(c => c.AssignedTo.Id == user.Id);
            return results.ToList();
        }

        public Task CreateUser(UserModel user)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            return usersCollection.InsertOneAsync(user);
        }

        public Task CreateChore(ChoreModel chore)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            return choresCollection.InsertOneAsync(chore);
        }

        public Task UpdateChore(ChoreModel chore)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);

            var filter = Builders<ChoreModel>.Filter.Eq("Id", chore.Id);
            return choresCollection.ReplaceOneAsync(filter, chore, options: new ReplaceOptions { IsUpsert = true  });
        }

        public Task DeleteChore(ChoreModel chore)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            return choresCollection.DeleteOneAsync(c => c.Id == chore.Id);
        }

        public async Task CompleteChore(ChoreModel chore)
        {
            //var choreCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            //var filter = Builders<ChoreModel>.Filter.Eq(field: "Id", chore.Id);
            //await choreCollection.ReplaceOneAsync(filter, chore);

            //var choreHistoryCollection = ConnectToMongo<ChoreHistoryModel>(ChoreCollection);
            //await choreHistoryCollection.InsertOneAsync(document:new ChoreHistoryModel(chore));

            var client = new MongoClient(ConnectionString);
            using var session = await client.StartSessionAsync();

            session.StartTransaction();

            try
            {
                var db = client.GetDatabase(DatabaseName);
                var choresCollection = db.GetCollection<ChoreModel>(ChoreCollection);
                var filter = Builders<ChoreModel>.Filter.Eq(field:"Id", chore.Id);
                await choresCollection.ReplaceOneAsync(filter, chore);

                var choreHistoryCollection = db.GetCollection<ChoreHistoryModel>(ChoreHistoryCollection);
                await choreHistoryCollection.InsertOneAsync(document: new ChoreHistoryModel(chore));

                await session.CommitTransactionAsync();

            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                Console.WriteLine(ex.Message);
            }

        }
    }
}
