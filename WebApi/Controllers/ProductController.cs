using System.Collections.Generic;
using System.Web.Http;
using ShopifyApp.Info.Models;
using ShopifyApp.Dac.Repositories;

namespace ShopifyApp.WebApi.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
        private readonly ProductDac _dac = new ProductDac("YOUR_CONNECTION_STRING");

        [HttpGet]
        [Route("")]
        public IEnumerable<ProductInfo> Get()
        {
            // TODO: implement DB retrieval
            return new List<ProductInfo>();
        }
    }
}
