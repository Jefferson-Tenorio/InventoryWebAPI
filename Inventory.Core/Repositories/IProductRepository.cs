using Inventory.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Repositories
{
    public interface IProductRepository
    {
        void Add(IProduct product);
        void Remove(int productId);
        IProduct GetById(int productId);
        IEnumerable<IProduct> GetAll();
    }
}
