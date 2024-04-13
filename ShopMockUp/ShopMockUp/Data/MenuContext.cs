using Microsoft.EntityFrameworkCore;
using ShopMockUp.Models;

namespace ShopMockUp.Data
{
    public class MenuContext :DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) :base(options)

        {
        

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopItemInformation>().HasKey(item => new
            {
                item.shopItemID,
                item.infoId,

            });
           // modelBuilder.Entity<ShopItemInformation>().HasOne(inf=> inf.shopItemID).WithMany
          base.OnModelCreating(modelBuilder);
        }
    }
}
