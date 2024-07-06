using Inventory.Core.Interfaces;
using Inventory.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Persistence
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        public ProductContext()
        {

        }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            //Conexão adciona no API.
        }
    }
}
