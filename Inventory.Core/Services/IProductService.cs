using Inventory.Core.DTOs;
using Inventory.Core.Interfaces;
using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Services
{
    public interface IProductService
    {
        Task<Product> CreateProductAsync(ProductDTO productDTO);
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task DeleteProduct(int id);
        Task DeleteProduct(ProductDTO productDTO);

        Task<Product> UpdateProduct(ProductDTO productDTO);

    }
}
