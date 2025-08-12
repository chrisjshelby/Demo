using System;
using System.Data.Entity;
using System.Linq;

namespace Demo.WebApp.Data
{
    public class Demo : DbContext
    {
        // Your context has been configured to use a 'Demo' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Demo.WebApp.Data.Demo' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Demo' 
        // connection string in the application configuration file.
        public Demo()
            : base("name=Contact")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Entities.Contact> Contacts { get; set; }
        public virtual DbSet<Entities.Contact_Phone> Contact_Phones { get; set; }
    }
}