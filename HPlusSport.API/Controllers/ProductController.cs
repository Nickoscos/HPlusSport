using HPlusSport.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController (ShopContext context) 
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IActionResult GetAllProducts() {
            return Ok(_context.Products.ToArray());
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            return Ok(product);
        }

    }
}
