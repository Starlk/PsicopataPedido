using Microsoft.EntityFrameworkCore;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Infraestructrue.Context
{
    public class PsicopataPedidoContext : DbContext
    {
        public PsicopataPedidoContext()
        {
        }

        public PsicopataPedidoContext(DbContextOptions<PsicopataPedidoContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<Orden> ordens { get; set; }   
        public DbSet<OrderList> orderlist { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,4)");
            builder.Entity<Orden>()
                .Property(p => p.Total)
                .HasColumnType("decimal(18,4)");
            builder.Entity<User>()
                .Property(p => p.Wallet)
                .HasColumnType("decimal(18,4)");
        }

    }
}
