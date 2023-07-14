using lesson25.Enum;
using lesson25.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson25.Data
{
    public class UserDb : DbContext
    {
        private readonly string connectionString = "Server=localhost;Host = localhost; Port=5432; User Id=postgres; Password=0124; Database=UserDb;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object value = optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(p => p.Gender)
                .HasDefaultValue(Gender.Male)
                .HasConversion<string>();
        }
        public DbSet<User> Users { get; set; }
    }
}
