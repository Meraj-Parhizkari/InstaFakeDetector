using InstaFakeDetector.Entities;

namespace InstaFakeDetector.Services.Contracts;

public interface IProductService
{
    void AddNewProduct(Product product);
    IList<Product> GetAllProducts();
}