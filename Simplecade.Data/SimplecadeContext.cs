using System;
using Microsoft.EntityFrameworkCore;

namespace Simplecade.Data
{
    public class SimplecadeContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<System> Systems { get; set; }
        public DbSet<Configuration> Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = arcade.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
