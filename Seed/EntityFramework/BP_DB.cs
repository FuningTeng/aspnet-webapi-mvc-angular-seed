namespace Seed.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Seed.Models;
    public class BP_DB : DbContext
    {
        // Your context has been configured to use a 'BP_DB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BestPracticeAgular.EntityFramework.BP_DB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BP_DB' 
        // connection string in the application configuration file.
        public BP_DB()
            : base("name=BP_DB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
    }
}