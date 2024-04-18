using APIMongoDB.Entities;
using MongoDB.Driver;

namespace APIMongoDB.Data
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
