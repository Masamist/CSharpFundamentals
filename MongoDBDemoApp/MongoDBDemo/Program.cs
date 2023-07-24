using MongoDataAccess.DataAccess;
using MongoDB.Driver;
using MongoDBDemo;
using MongoDataAccess.Models;
using System.Runtime.CompilerServices;

namespace MongoDBDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ChoreDataAccess db = new ChoreDataAccess();
            await db.CreateUser(new UserModel() { FirstName = "Masami", LastName = "Stonebridge" });
            var users = await db.GetAllUsers();

            var chore = new ChoreModel() 
            { 
                AssignedTo = users.First(), 
                ChoreText = "Mow the Lawn",
                FrequencyInDays = 7 
            };
            await db.CreateChore(chore);
            var chores = await db.GetAllChores();

            var newChore = chores.First();
            newChore.LastCompleted = DateTime.UtcNow;

            await db.CompleteChore(newChore);
        }
        
    }
}

