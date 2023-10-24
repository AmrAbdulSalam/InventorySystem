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
    }
}
