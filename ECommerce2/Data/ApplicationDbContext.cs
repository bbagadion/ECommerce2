using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ECommerce2.Models;

namespace ECommerce2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ECommerce2.Models.Cart> Cart { get; set; }
        public DbSet<ECommerce2.Models.Customer> Customer { get; set; }
        public DbSet<ECommerce2.Models.OrderDetail> OrderDetail { get; set; }
        public DbSet<ECommerce2.Models.OrderHeader> OrderHeader { get; set; }
        public DbSet<ECommerce2.Models.Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity< Product > ().HasData(
                new Product { Product_ID = 1, Product_Name = "Apple", Product_Description = "Crisp Apple", Product_Price = 2.00, Product_Photo = "apple.jpg"},
                new Product { Product_ID = 2, Product_Name = "Orange", Product_Description = "Sweet Orange", Product_Price = 1.00, Product_Photo = "orange.jpg" },
                new Product { Product_ID = 3, Product_Name = "Pear", Product_Description = "Delicious Pear", Product_Price = 3.00, Product_Photo = "pear.jpg" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
