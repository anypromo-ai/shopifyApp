using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Biz;
using Info;

namespace WebApi.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
        private readonly ProductBiz _biz = new ProductBiz();

        [HttpGet, Route("")]
        public async Task<IHttpActionResult> GetProducts()
        {
            List<ProductInfo> products = await _biz.GetProductsAsync();
            return Ok(products);
        }
    }
}
