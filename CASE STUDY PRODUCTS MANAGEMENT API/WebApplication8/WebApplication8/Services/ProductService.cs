using WebApplication8.models.WebApplication8.models;
using WebApplication8.Repositors;

namespace WebApplication8.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public void AddProduct(Product productObj)
        {
            _repository.AddProduct(productObj);
        }

        public void UpdateProduct(Product productobj)
        {
            _repository.UpdateProduct(productobj);
        }

        public void DeleteProduct(Product productobj)
        {
            _repository.DeleteProduct(productobj);
        }
        public List<Product> GetProductsByCategory(string category)
        {
            return _repository.GetProductsByCategory(category);
        }

        public List<Product> GetOutOfStockProducts()
        {
            return _repository.GetOutOfStockProducts();
        }

        public List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _repository.GetProductsByPriceRange(minPrice, maxPrice);
        }

        public List<string> GetAllCategories()
        {
            return _repository.GetAllCategories();
        }
    }
}

