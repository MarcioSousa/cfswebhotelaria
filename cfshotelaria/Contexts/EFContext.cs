using cfshotelaria.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace cfshotelaria.Contexts
{
    public class EFContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public EFContext() : base("cfs_hotelaria") { }

        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemProdutoPedido> ItemProdutoPedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
    }
}