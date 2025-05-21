using System.Collections.Generic;
using System.Data.SqlClient;
using ShopifyApp.Info.Models;

namespace ShopifyApp.Dac.Repositories
{
    public class ProductDac
    {
        private readonly string _connectionString;

        public ProductDac(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveProducts(IEnumerable<ProductInfo> products)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (var product in products)
                {
                    var cmd = new SqlCommand("INSERT INTO Products (Id, Title, Price) VALUES (@Id, @Title, @Price)", conn);
                    cmd.Parameters.AddWithValue("@Id", product.Id);
                    cmd.Parameters.AddWithValue("@Title", product.Title);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
