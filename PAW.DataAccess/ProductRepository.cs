using PAW.DataAccess.Entities;

namespace PAW.DataAccess;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
}

public class ProductRepository : IProductRepository
{
    private readonly ProductContext _context;

    public ProductRepository(ProductContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _context.Products.ToList();
    }
}