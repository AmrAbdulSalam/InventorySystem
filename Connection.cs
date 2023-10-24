using System.Data.SqlClient;
using System.Text;
using InventoryManagementSystem.ProductInfo;

namespace InventorySystem
{
    class Connection
    {
        private readonly string _connectionString = "Data Source=DESKTOP-NUK8KNC\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
        public void InsertToDatabase(Product product)
        {
            var query = $"INSERT INTO Products VALUES ('{product.ProductName}' , {product.ProductPrice} , {product.ProductQuantity})";
            using (var con = new SqlConnection(_connectionString))
            {
                con.Open();
                var cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }

        public async Task<string> ViewProduct(string query)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                await con.OpenAsync();
                var output = "Product Name \t Product Price \t Product Quant\n";
                using (var cmd = new SqlCommand(query, con))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            output +=
                            reader.GetValue(0).ToString() + "\t" +
                            reader.GetValue(1).ToString() + "\t" +
                            reader.GetValue(2).ToString() + "\n";
                        }
                        return output;
                    }
                }

            }

        }
    }
}
