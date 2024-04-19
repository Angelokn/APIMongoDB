using APIMongoDB.Data;
using APIMongoDB.Entities;
using MongoDB.Driver;

namespace APIMongoDB.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductContext _context;

        public ProductRepository(IProductContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Product>>GetProducts()
        {
            return await _context.Products.Find(p => true)
                .ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.Find(p => p.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter
                .ElemMatch(p => p.Name, name);
            
            return await _context.Products.Find(filter)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory (string categoryName)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter
                .Eq(p => p.Category, categoryName);

            return await _context.Products.Find(filter)
                .ToListAsync();
        }
    }
}
