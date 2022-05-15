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
        public PsicopataPedidoContext(DbContextOptions<PsicopataPedidoContext> options) : base(options) { }

        DbSet<User> users { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<Category> categories { get; set; }
        DbSet<ShoppingList> ShoppingLists { get; set; }
        DbSet<Orden> ordens { get; set; }   

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
