using WebApplication7.models;

namespace WebApplication7.Repositories

{

    public interface IProductRepository
    {
       
            List<Product> GetAllProducts();
            Product GetProductById(int id);
            void AddProduct(Product productObj);
            void UpdateProduct(Product productobj);
            void DeleteProduct(Product productobj);
    }
    }

