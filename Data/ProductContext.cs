using APIMongoDB.Entities;
using MongoDB.Driver;

namespace APIMongoDB.Data
{
    public class ProductContext : IProductContext
    {
        public IMongoCollection<Product> Products { get; set; }
        public ProductContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>
                ("DatabaseSettings:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionName"));

            //ProductContextSeed.SeedData(Products);
        }
    }
}
