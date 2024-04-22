using Microsoft.EntityFrameworkCore;
using ShopMockUp.Models;

namespace ShopMockUp.Data
{
    public class MenuContext :DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>().HasKey(di => new
            {
                di.itemId,
                di.playerId
            });
            modelBuilder.Entity<Items>().HasOne(d => d.player).WithMany(di => di.items).HasForeignKey(d => d.itemId);
            modelBuilder.Entity<Items>().HasOne(i => i.item).WithMany(di => di.itemsList).HasForeignKey(i => i.playerId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Item> Ingredients { get; set; }
        public DbSet<Items> DishIngredients { get; set; }
    }
}