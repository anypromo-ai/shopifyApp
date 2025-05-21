using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Biz;

namespace WebApi
{
    public class SimpleResolver : IDependencyResolver
    {
        private readonly ShopifyBiz _biz;
        public SimpleResolver(ShopifyBiz biz)
        {
            _biz = biz;
        }
        public IDependencyScope BeginScope() => this;
        public void Dispose() { }
        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(ShopifyBiz))
                return _biz;
            return null;
        }
        public IEnumerable<object> GetServices(Type serviceType) => new object[0];
    }
}
