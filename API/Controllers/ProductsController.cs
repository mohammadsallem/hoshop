using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Enitity;
using Core.Interface;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepositry _repo;
        public ProductsController(IProductRepositry repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {

            var product = await _repo.GetProductsAsync();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {

            return await _repo.GetProductByIdAsync(id);
        }

      [HttpGet("brands")]
       public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
              return Ok(await _repo.GetProductBrandsAsync());
           
        }

       [HttpGet("types")]
       public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductTypes()
        {
              return Ok(await _repo.GetProductTypesAsync());
        }

    }
}