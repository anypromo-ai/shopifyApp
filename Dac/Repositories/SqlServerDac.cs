using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Info.Models;

namespace Dac.Repositories
{
    public class SqlServerDac
    {
        private readonly string _connectionString;

        public SqlServerDac(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task SaveProductsAsync(IEnumerable<ProductInfo> products)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                foreach (var p in products)
                {
                    var cmd = new SqlCommand("INSERT INTO Products(Id,Title,Description,Price) VALUES(@Id,@Title,@Description,@Price)", conn);
                    cmd.Parameters.AddWithValue("@Id", p.Id);
                    cmd.Parameters.AddWithValue("@Title", p.Title);
                    cmd.Parameters.AddWithValue("@Description", p.Description);
                    cmd.Parameters.AddWithValue("@Price", p.Price);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // TODO: Save orders and customers
    }
}
