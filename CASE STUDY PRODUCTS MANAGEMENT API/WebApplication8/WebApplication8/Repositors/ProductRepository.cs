using WebApplication8.models.WebApplication8.models;

namespace WebApplication8.Repositors
{
    public class ProductRepository : IProductRepository
    {
        public SalesDbContext _context;
        public ProductRepository(SalesDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product productObj)
        {

            _context.Products.Add(productObj);
            _context.SaveChanges();

        }
        public void UpdateProduct(Product productobj)
        {
            _context.Products.Update(productobj);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product productobj)
        {
            _context.Products.Remove(productobj);
            _context.SaveChanges();
        }

        public void categoryProduct(Product produtobj)
        {
            throw new NotImplementedException();
        }
        /*public void categoryProduct(Product produtobj);
{
   _context.Products.Read(productobj);
   _context.SaveChanges();*/
        public List<Product> GetProductsByCategory(string category)
        {
            return _context.Products.Where(p => p.category == category).ToList();
        }

        public List<Product> GetOutOfStockProducts()
        {
            return _context.Products.Where(p => p.quantity == 0).ToList();
        }

        public List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _context.Products.Where(p => p.price >= minPrice && p.price <= maxPrice).ToList();
        }

        public List<string> GetAllCategories()
        {
            return _context.Products.Select(p => p.category).Distinct().ToList();
        }

    }
}


