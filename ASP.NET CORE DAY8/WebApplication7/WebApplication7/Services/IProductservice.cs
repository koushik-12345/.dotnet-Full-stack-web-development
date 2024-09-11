namespace WebApplication7.Services;
using WebApplication7.models;

public interface IProductService
{
    List<Product> GetAllProducts();
    Product GetProductById(int id);
    void AddProduct(Product productObj);
    void UpdateProduct(Product productobj);

    void DeleteProduct(Product productobj);
}
