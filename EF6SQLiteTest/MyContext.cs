using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using SQLite.CodeFirst;

namespace EF6SQLiteTest
{
    public class MyContext : DbContext
    {
        public MyContext(DbConnection connection) 
            : base(connection, contextOwnsConnection: true)
        { }

        public MyContext(string connectionString)           
        :   base(connectionString)
        {
            
        }

        public DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            var initializer = new SqliteDropCreateDatabaseAlways<MyContext>(modelBuilder);
            Database.SetInitializer(initializer);
        }
    }
}
