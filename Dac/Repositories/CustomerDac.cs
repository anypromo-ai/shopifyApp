using System.Collections.Generic;
using System.Data.SqlClient;
using ShopifyApp.Info.Models;

namespace ShopifyApp.Dac.Repositories
{
    public class CustomerDac
    {
        private readonly string _connectionString;
        public CustomerDac(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SaveCustomers(IEnumerable<CustomerInfo> customers)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                foreach (var customer in customers)
                {
                    var cmd = new SqlCommand("INSERT INTO Customers (Id, FirstName, LastName, Email) VALUES (@Id, @FirstName, @LastName, @Email)", conn);
                    cmd.Parameters.AddWithValue("@Id", customer.Id);
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
