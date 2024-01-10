using Assignment2OnAPI.Model;

namespace Assignment2OnAPI.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int id);

       Product ProductById(int id);

       Product ProductByName(string name);

        List<Product> ProductByCategory(string category);

    }
}
