using APIMongoDB.Entities;
using MongoDB.Driver;

namespace APIMongoDB.Data
{
    public class ProductContextSeed
    {
        public static void SeedData (IMongoCollection<Product> collection)
        {
            bool prodList = collection.Find(p => true).Any();
            if (!prodList)
            {
                collection.InsertManyAsync(GetProducts());
            }
        }

        private static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
                {
                    new Product() { Id = "1", Name = "teste", Category = "teste", Description = "teste", Image = "teste", Price = 1.5M },
                    new Product() { Id = "2", Name = "teste", Category = "teste", Description = "teste", Image = "teste", Price = 1.5M }

                };
        }
    }
}