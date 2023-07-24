using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\Masami\\C#-basics\\Extensibility\\Extensibility\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
