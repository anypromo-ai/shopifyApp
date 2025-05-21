using System.Collections.Generic;
using System.Web.Http;
using ShopifyApp.Info.Models;
using ShopifyApp.Dac.Repositories;

namespace ShopifyApp.WebApi.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        private readonly CustomerDac _dac = new CustomerDac("YOUR_CONNECTION_STRING");

        [HttpGet]
        [Route("")]
        public IEnumerable<CustomerInfo> Get()
        {
            // TODO: implement DB retrieval
            return new List<CustomerInfo>();
        }
    }
}
