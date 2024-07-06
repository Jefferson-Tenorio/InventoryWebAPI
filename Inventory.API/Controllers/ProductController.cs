using Inventory.Core.DTOs;
using Inventory.Core.Mappers;
using Inventory.Core.Models;
using Inventory.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository) 
        {

            _productRepository = productRepository;

        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _productRepository.GetAllAsync();
            return Ok(products);

        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] ProductDTO productDto)
        {
            if (productDto == null)
            {
                return BadRequest("Product data is null.");
            }

            // Mapear ProductDto para Product
            var product = ProductMapper.ToModel(productDto);
           

            await _productRepository.AddAsync(product);

            // Retornar resposta com a URL do novo recurso criado
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        } 

    }
}
