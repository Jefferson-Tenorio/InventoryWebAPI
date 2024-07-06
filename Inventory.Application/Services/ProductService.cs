using Inventory.Core.Interfaces;
using Inventory.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class ProductService : IProductService
    {
        public void AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public IProduct GetProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
