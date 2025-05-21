using System.Collections.Generic;
using System.Data.SqlClient;
using ShopifyApp.Info.Models;

namespace ShopifyApp.Dac.Repositories
{
    public class OrderDac
    {
        private readonly string _connectionString;
        public OrderDac(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveOrders(IEnumerable<OrderInfo> orders)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (var order in orders)
                {
                    var cmd = new SqlCommand("INSERT INTO Orders (Id, CreatedAt, TotalPrice) VALUES (@Id, @CreatedAt, @TotalPrice)", conn);
                    cmd.Parameters.AddWithValue("@Id", order.Id);
                    cmd.Parameters.AddWithValue("@CreatedAt", order.CreatedAt);
                    cmd.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
