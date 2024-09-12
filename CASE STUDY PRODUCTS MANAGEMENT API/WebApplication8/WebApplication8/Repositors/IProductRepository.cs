using WebApplication8.models.WebApplication8.models;

namespace WebApplication8.Repositors
{
    

    public interface IProductRepository
    {

        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product productObj);
        void UpdateProduct(Product productobj);
        void DeleteProduct(Product productobj);
       
        List<Product> GetProductsByCategory(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice);
        List<string> GetAllCategories();
    }
}

