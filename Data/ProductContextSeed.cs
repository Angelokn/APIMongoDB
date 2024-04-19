using APIMongoDB.Entities;
using MongoDB.Driver;

namespace APIMongoDB.Data
{
    public class ProductContextSeed
    {
        public static void SeedData (IMongoCollection<ProductContext> collection)
        {
            bool prodList = collection.Find(p => true).Any();
            if (!prodList)
            {
                collection.InsertManyAsync(GetProducts());
            }

            private static IEnumerable<Product> GetProducts()
            {
                return new List<Product>()
                {
                    new Product() { Id = 1, Name = "", Category = "", Description = "", Image = "", Price = 1.5M },
                    new Product() { Id = 1, Name = "", Category = "", Description = "", Image = "", Price = 1.5M },

                };
                }
            }
        }
    }
}
