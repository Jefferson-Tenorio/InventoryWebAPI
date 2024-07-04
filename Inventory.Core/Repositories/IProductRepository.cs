using Inventory.Core.Interfaces;
using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task DeleteAsync(Product product);
        Task DeleteAsync(int productId);
        Task UpdateAsync(Product product);
        Task<Product> GetByIdAsync(int productId);
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
