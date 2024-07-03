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
        public static ProductDTO ToDTO(BaseProduct product)
        {
            ProductDTO productDTO = null;

            if(product is PerishableProduct perishable)
            {
                productDTO = new ProductDTO
                {
                    Id = perishable.Id,
                    Name = perishable.Name,
                    DateAdded = perishable.DateAdded,
                    ExpiryDate = perishable.ExpiryDate,
                    PurchasePrice = perishable.PurchasePrice,
                    SalePrice = perishable.SalePrice,
                    StockQuantity = perishable.StockQuantity,
                    ProductType = "Perishable"
                };
            }
            //else if (product is AnyOther product)
            //{
            //  productDTO = new ProductDTO
            //  {
            //      ...
            //  };
            //}

            if(productDTO == null)
            {
                throw new ArgumentException("Unsupported product type.");
            }

            return productDTO;
        }

        public static BaseProduct ToModel(ProductDTO productDTO)
        {
            BaseProduct product = null;

            switch(productDTO.ProductType)
            {
                case "Perishale":
                    {
                        product = new PerishableProduct();
                        break;
                    }
                // case "AnyOther":
                //{
                //  product = new AnyOtherProduct();
                //  break;
                //}
                default:
                    throw new ArgumentException("Invalid Product Type");
            }

            product.Id = productDTO.Id;
            product.Name = productDTO.Name;
            product.DateAdded = productDTO.DateAdded;
            product.PurchasePrice = productDTO.PurchasePrice;
            product.SalePrice = productDTO.SalePrice;
            product.StockQuantity = productDTO.StockQuantity;

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
