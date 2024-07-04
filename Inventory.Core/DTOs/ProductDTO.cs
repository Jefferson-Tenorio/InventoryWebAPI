using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Supplay { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int StockQuantity { get; set; }
        public string ProductType {  get; set; }
    }
}
