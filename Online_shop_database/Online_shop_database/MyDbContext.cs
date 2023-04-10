using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_shop_database
{


    public class MyDbContext : DbContext
        {
            public DbSet<Users> Users { get; set; }
            public DbSet<Item> Items { get; set; }
            public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LAB215-12); Database=practice_shop_10/04/23; User Id=sa; Password=12345;");
        }
    }

}


   

