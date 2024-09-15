using Configurations;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class MarketDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-AAT1VEH;Initial Catalog=MarketDB;Integrated Security=True;Encrypt=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}









