using Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Repository
{
    public class ApplicationContext : IdentityDbContext<User>
    {
       public DbSet<Class> Classes { get; set; } = null!;
       public DbSet<Cloth> Cloths { get; set; } = null!;
       public DbSet<Material> Materials { get; set; } = null!;
       public DbSet<Size> Sizes { get; set; } = null!;
       public DbSet<ShopCartItem> ShopCartItems { get; set; } = null!;
       public DbSet<Order> Orders { get; set; } = null!;
       public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

    }
}
