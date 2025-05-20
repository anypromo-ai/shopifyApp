using System.Collections.Generic;
using System.Web.Http;
using ShopifyApp.Info.Models;
using ShopifyApp.Dac.Repositories;

namespace ShopifyApp.WebApi.Controllers
{
    [RoutePrefix("api/orders")]
    public class OrderController : ApiController
    {
        private readonly OrderDac _dac = new OrderDac("YOUR_CONNECTION_STRING");

        [HttpGet]
        [Route("")]
        public IEnumerable<OrderInfo> Get()
        {
            // TODO: implement DB retrieval
            return new List<OrderInfo>();
        }
    }
}
