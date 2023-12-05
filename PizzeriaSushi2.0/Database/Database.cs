using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzeriaSushi2._0.Models;

namespace PizzeriaSushi2._0.Database
{
    public class Database : DbContext
    {

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<ItemImage> ItemImages { get; set; }

        public Database(DbContextOptions<Database> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connetionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
        }

    }
}
