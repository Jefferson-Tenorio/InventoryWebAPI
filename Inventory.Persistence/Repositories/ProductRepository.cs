using Inventory.Core.Interfaces;
using Inventory.Core.Models;
using Inventory.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product product)
        {
             _context.products.Remove(product);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.products.FindAsync(id);
            if(product != null)
            {
                _context.products.Remove(product);
                await _context.SaveChangesAsync();
            }        
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.products.ToListAsync();
            
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await _context.products.FindAsync(productId);
        }

        public async Task UpdateAsync(Product product)
        {
            _context.products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
