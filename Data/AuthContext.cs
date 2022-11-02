using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using AuthAPI.Models;

namespace AuthAPI.Data
{
    public class AuthContext: DbContext
    {
        private IConfiguration _configuration;

        public DbSet<User> Users { get; set; }

        public AuthContext(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {

            String connectionString = _configuration.GetConnectionString("mysql");
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            builder.UseLazyLoadingProxies();
            builder.UseMySql(connectionString, serverVersion)
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }

    }
}