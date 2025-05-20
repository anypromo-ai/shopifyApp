using System.Collections.Generic;
using ShopifyApp.Dac;
using ShopifyApp.Info;

namespace ShopifyApp.Biz
{
    public class ShopifyBiz
    {
        private readonly ShopifyDac _dac = new ShopifyDac();

        public void SyncAll()
        {
            var products = _dac.FetchProducts();
            var orders = _dac.FetchOrders();
            var customers = _dac.FetchCustomers();

            _dac.SaveProducts(products);
            _dac.SaveOrders(orders);
            _dac.SaveCustomers(customers);
        }

        public IEnumerable<ProductInfo> GetProducts() => _dac.FetchProducts();
        public IEnumerable<OrderInfo> GetOrders() => _dac.FetchOrders();
        public IEnumerable<CustomerInfo> GetCustomers() => _dac.FetchCustomers();
    }
}
