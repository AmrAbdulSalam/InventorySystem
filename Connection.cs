using InventoryManagementSystem.ProductInfo;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InventorySystem
{
    public static class Connection
    {
        private static readonly string _connection = "mongodb+srv://amr:IapNpXMCOT535J8E@cluster0.mwp6uhf.mongodb.net/Inventory?retryWrites=true&w=majority";
        private static readonly MongoClient _client = new MongoClient(_connection);
        private static readonly IMongoDatabase _database = _client.GetDatabase("Inventory");
        private static readonly IMongoCollection<Product> _collection = _database.GetCollection<Product>("Products");

        public static void InsertProduct(Product product)
        {
            _collection.InsertOne(product);
        }

        public static Task<List<Product>> ViewProductsAsync()
        {
            var allProducts = _collection.Find(new BsonDocument()).ToListAsync();
            return allProducts;
        }

    }
}