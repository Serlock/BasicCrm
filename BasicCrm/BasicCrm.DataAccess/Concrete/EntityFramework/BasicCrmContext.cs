using BasicCrm.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCrm.DataAccess.Concrete.EntityFramework
{
    public class BasicCrmContext : DbContext
    {
        public BasicCrmContext()
        {

        }

        public BasicCrmContext(DbContextOptions<BasicCrmContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BasicCrm;Trusted_Connection=True;");
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BasicCrmContext>
        {
            public BasicCrmContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<BasicCrmContext>();
                var connectionString = "Server=localhost;Database=NewDatabase;Trusted_Connection=True;";
                builder.UseSqlServer(connectionString);
                return new BasicCrmContext(builder.Options);
            }
        }
    }
}
