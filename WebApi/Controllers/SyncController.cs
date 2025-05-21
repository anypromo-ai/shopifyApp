using System.Web.Http;
using ShopifyApp.Biz.Services;

namespace ShopifyApp.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class SyncController : ApiController
    {
        private readonly ShopifyBiz _biz = new ShopifyBiz("YOUR_CONNECTION_STRING");

        [HttpPost]
        [Route("sync")]
        public IHttpActionResult Sync()
        {
            _biz.SyncProducts();
            // TODO: call SyncOrders and SyncCustomers
            return Ok("Sync completed");
        }
    }
}
