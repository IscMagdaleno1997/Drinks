using DrinkAndGo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext>options) : base(options) 
        {

        }

        public DbSet<ShopingCartItem> shopingCartItems { get; set; }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
