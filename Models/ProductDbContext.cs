using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carwash.Models;

namespace Carwash.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) 
            : base(options)
        { 
        
        }

        public DbSet<Product> Products { get; set; } 
        public DbSet<ClassAuto> ClassAutos { get; set; }
        public DbSet<NewsModel> NewsModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<ClassAuto>()
                    .HasOne(h => h.Product)
                    .WithMany(h => h.ClassAutos)
                    .HasForeignKey(h => h.ProductID);
            
        }
    }
}
