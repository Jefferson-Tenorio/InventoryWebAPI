using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Interfaces
{
    public interface IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int StockQuantity { get; set; }

        void DecreaseStock(int amount);
        string DisplayProductDetails();
       
    }
}
