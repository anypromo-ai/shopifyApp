using System.Collections.Generic;
using System.Web.Http;
using ShopifyApp.Biz;
using ShopifyApp.Info;

namespace ShopifyApp.Web.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductBiz _biz = new ProductBiz();

        [HttpGet]
        [Route("api/products")]
        public IEnumerable<ProductInfo> Get()
        {
            return _biz.GetAllProducts();
        }
    }
}
