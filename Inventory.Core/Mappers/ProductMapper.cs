using Inventory.Core.DTOs;
using Inventory.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Mappers
{
    public static class ProductMapper
    {
        public static ProductDTO ToDTO(Product product)
        {

            ProductDTO productDTO = null;

            productDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Supplay = product.Supplay,
                Description = product.Description,
                    PurchasePrice = product.PurchasePrice,
                    SalePrice = product.SalePrice,
                    StockQuantity = product.StockQuantity,
                    ProductType = "Perishable"
                };

            if(productDTO == null)
            {
                throw new ArgumentException("Unsupported product type.");
            }

            return productDTO;
        }

        public static Product ToModel(ProductDTO productDTO)
        {
            Product product = new Product();

            product.Name = productDTO.Name;
            product.DateAdded = DateTime.Now;
            product.PurchasePrice = productDTO.PurchasePrice;
            product.SalePrice = productDTO.SalePrice;
            product.StockQuantity = productDTO.StockQuantity;
            product.Description = productDTO.Description;
            product.Supplay = productDTO.Supplay;
            product.ExpiryDate = DateTime.Now;
            product.ProductType = productDTO.ProductType;

        //    public int Id { get; set; }
        //public string Name { get; set; }
        //public string Supplay { get; set; }
        //public string Description { get; set; }
        //public DateTime DateAdded { get; set; }
        //public DateTime? ExpiryDate { get; set; }
        //public decimal PurchasePrice { get; set; }
        //public decimal SalePrice { get; set; }
        //public int StockQuantity { get; set; }
        //public string ProductType { get; set; }

            //if (product is PerishableProduct perishable)
            //{
            //    perishable.ExpiryDate = productDTO.ExpiryDate;
            //    // Outros campos específicos de PerishableProduct, se houver
            //}
            //else if (product is DigitalProduct digital)
            //{
            //    digital.DownloadLink = productDTO.DownloadLink;
            //    digital.DownloadLimit = productDTO.DownloadLimit;
            //    // Outros campos específicos de DigitalProduct, se houver
            //}

            return product;

        }
    }
}
