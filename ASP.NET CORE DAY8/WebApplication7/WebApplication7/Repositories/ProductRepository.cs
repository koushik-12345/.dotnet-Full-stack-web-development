using static WebApplication7.Repositories.IProductRepository;
using WebApplication7.models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace WebApplication7.Repositories
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

    }
    }

