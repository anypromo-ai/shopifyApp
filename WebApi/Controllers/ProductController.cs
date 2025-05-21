using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Biz;
using Info.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductController : ApiController
    {
        private readonly ShopifyBiz _biz;
        public ProductController(ShopifyBiz biz)
        {
            _biz = biz;
        }

        [HttpPost, Route("sync")]
        public async Task<IHttpActionResult> Sync()
        {
            List<ProductInfo> products = await _biz.SyncProductsAsync();
            return Ok(products);
        }
    }
}
