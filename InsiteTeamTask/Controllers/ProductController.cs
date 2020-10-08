using System.Collections.Generic;
using InsiteTeamTask.Models;
using InsiteTeamTask.Repositories.ProductRepo;
using Microsoft.AspNetCore.Mvc;

namespace InsiteTeamTask.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Product>> Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("id is required");
            }

            Product product = _productRepository.Get(id);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return NotFound("No records found");
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> Get()
        {
            List<Product> products = _productRepository.GetAll();
            if (products.Count > 0)
            {
                return Ok(products);
            }
            else
            {
                return NotFound("No records found");
            }
        }
    }
}
