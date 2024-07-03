using Inventory.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Services
{
    public interface IProductService
    {
        void AddProduct(IProduct product);
        void RemoveProduct(int productId);
        IProduct GetProduct(int productId);
        IEnumerable<IProduct> GetAll();

    }
}
