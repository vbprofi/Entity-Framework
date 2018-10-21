using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6SQLiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext("Data Source =" + Environment.CurrentDirectory + @"\test.db; Version = 3;");
            var entities = context.MyEntities.ToList();
            context.MyEntities.Add(new MyEntity {Id = 10, Stuff = "I exist "});
            context.SaveChanges();
            Console.WriteLine("Enter drücken, zum Beenden...");
            Console.ReadLine();
        }
    }
}
