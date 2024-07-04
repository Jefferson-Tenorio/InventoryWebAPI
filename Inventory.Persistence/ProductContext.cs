using Inventory.Core.Interfaces;
using Inventory.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Persistence
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; };

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            //Conexão adciona no API.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura o mapeamento para a tabela de produtos (TPH)
            modelBuilder.Entity<BaseProduct>()
                .HasDiscriminator<string>("ProductType")
                .HasValue<PerishableProduct>("perishable");   // Discriminador para produtos perecíveis
        //        .HasValue<NonPerishableProduct>("nonperishable")  // Discriminador para produtos não perecíveis
        //        .HasValue<DigitalProduct>("digital");   // Discriminador para produtos digitais
        }
    }
}
