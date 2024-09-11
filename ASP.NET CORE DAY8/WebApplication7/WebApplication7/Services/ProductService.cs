namespace WebApplication7.Services;
using WebApplication7.models;
using WebApplication7.Repositories;
using static WebApplication7.Repositories.IProductRepository;


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
}

