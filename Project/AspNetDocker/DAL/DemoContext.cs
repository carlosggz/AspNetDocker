using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetDocker.DAL
{
    public class DemoContext : DbContext
    {
        static DemoContext()
        {
            Database.SetInitializer<DemoContext>(null);
        }

        public DemoContext()
            : base("Name=SqlServerDocker")
        {
            Database.CommandTimeout = 300;
        }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}