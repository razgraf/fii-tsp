using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace CodeFirstEF.Model
{
    internal class Context : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <OrderDetails> OrderDetails { get; set; }
        public DbSet <Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=RAZVAN-PC;Database=tspefcore; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasMany<Order>(o => o.Orders)
                .WithOne(c => c.Client);

            builder.Entity<OrderDetails>()
                .HasOne<Order>(od => od.Order)
                .WithMany(o => o.OrderDetails);

            builder.Entity<Product>()
                .HasMany<OrderDetails>(p => p.OrderDetails)
                .WithOne(od => od.Product);
        }

    }
}
