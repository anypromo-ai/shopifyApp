using System.Web.Http;
using ShopifyApp.Biz;

namespace ShopifyApp.WebApi.Controllers
{
    public class ShopifyController : ApiController
    {
        private readonly ShopifyBiz _biz = new ShopifyBiz();

        [HttpPost]
        [Route("api/sync")]
        public IHttpActionResult Sync()
        {
            _biz.SyncAll();
            return Ok("Sync completed");
        }

        [HttpGet]
        [Route("api/products")]
        public IHttpActionResult GetProducts()
        {
            return Ok(_biz.GetProducts());
        }

        [HttpGet]
        [Route("api/orders")]
        public IHttpActionResult GetOrders()
        {
            return Ok(_biz.GetOrders());
        }

        [HttpGet]
        [Route("api/customers")]
        public IHttpActionResult GetCustomers()
        {
            return Ok(_biz.GetCustomers());
        }
    }
}
