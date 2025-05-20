using Microsoft.AspNetCore.Mvc;
using ShopifyApp.Services;
using ShopifyApp.Models;

namespace ShopifyApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _service.GetProducts();
            return Ok(products);
        }
    }
}
