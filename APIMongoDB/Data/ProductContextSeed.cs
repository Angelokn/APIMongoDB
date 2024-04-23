using APIMongoDB.Entities;
using MongoDB.Driver;

namespace APIMongoDB.Data
{
    public class ProductContextSeed
    {
        //public static void SeedData (IMongoCollection<Product> collection)
        //{
        //    var prodList = collection.Find(p => true).Any();
        //    if (!prodList)
        //    {
        //        collection.InsertManyAsync(GetProducts());
        //    }
        //}

        public static async Task SeedData(IMongoCollection<Product> collection)
        {
            var count = await collection.CountDocumentsAsync(FilterDefinition<Product>.Empty);

            if (count == 0)
            {
                await collection.InsertManyAsync(GetProducts());
            }
        }

        private static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
                {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Caderno Espiral Pequeno",
                    Description = "Caderno espiral com 100 folhas pequeno capa dura",
                    Image = "caderno.png",
                    Price = 7.65M,
                    Category = "MaterialEscolar"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Borracha branca pequena",
                    Description = "Borracha branca pequena para lápis",
                    Image = "borracha.png",
                    Price = 4.55M,
                    Category = "MaterialEscolar"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Estojo de plástico pequeno",
                    Description = "Estojo de plástico pequeno azul",
                    Image = "estojo.png",
                    Price = 6.79M,
                    Category = "MaterialEscolar"
                }

                };
        }
    }
}