using System;
using System.Collections.Generic;
using System.Text;
using Eshop_11_4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eshop_11_4.Data
{
    public class ApplicationDbContext : IdentityDbContext<AuthenticateUser>
    {

        public DbSet<Product> Products
        {
            get;
            set;
        }
 

        public DbSet<Room> Rooms
        {
            get;
            set;
        }
        public DbSet<ProductType> ProductTypes
        {
            get;
            set;
        }
        /// <summary>
        /// Maybe CartLines
        /// </summary>
        public DbSet<CartLine> Lines
        {
            get;
            set;
        }
        public DbSet<Order> Orders
        {
            get;
            set;
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>(entity => {
                entity.ToTable("Products");
                entity.HasKey(x => x.ProductId);
                entity.HasOne(x => x.ProductType).WithMany(c => c.Products).HasForeignKey(f => f.ProductTypeId);
                entity.HasOne(x => x.Room).WithMany(c => c.Products).HasForeignKey(f => f.RoomId);
                entity.Property(x => x.DateCreated).HasDefaultValue(DateTime.UtcNow); 
            });

            builder.Entity<ProductType>(entity => {
                entity.ToTable("ProductTypes");
                entity.HasKey(x => x.ProductTypeId);
            });


            builder.Entity<Room>(entity => {
                entity.ToTable("Rooms");
                entity.HasKey(x => x.RoomId);
            });

            builder.Entity<Order>(entity => {
                entity.ToTable("Orders");
                entity.HasKey(x => x.OrderID);
                entity.HasOne(x => x.AuthenticateUser).WithMany(c => c.Orders).HasForeignKey(f => f.AuthenticateUserId);
                entity.Property(x => x.DateCreated).HasDefaultValue(DateTime.UtcNow);
            });

            builder.Entity<CartLine>(entity => {
                entity.ToTable("Lines");
                entity.HasKey(x => x.CartLineID);
                entity.HasOne(x => x.Order).WithMany(c => c.Lines).HasForeignKey(f => f.OrderID);
                entity.HasOne(x => x.Product).WithMany(c => c.Lines).HasForeignKey(f => f.ProductId);
            });

        }
    }
}
