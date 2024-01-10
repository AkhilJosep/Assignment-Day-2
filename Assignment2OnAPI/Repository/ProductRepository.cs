using Assignment2OnAPI.Model;

namespace Assignment2OnAPI.Repository
{
    public class ProductRepository : IProductRepository

    {
        public List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            try
            {
                products.Add(product);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeleteProduct(int id)
        {
            try
            {
                foreach (var item in products)
                {
                    if (item.ProductId == id)
                    {
                        products.Remove(item);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> ProductByCategory(string category)
        {
            try
            {
                List<Product> productCategory = new List<Product> ();
                foreach (var item in products)
                {
                    if (item.Category == category)
                        productCategory.Add(item);
                }
                return productCategory;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product ProductById(int id)
        {

            try
            {
                foreach (var product in products)
                {
                    if (product.ProductId == id)
                        return product;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product ProductByName(string name)
        {

            try
            {
                foreach (var item in products)
                {
                    if (item.ProductName == name)
                        return item;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                foreach (var item in products)
                {
                    if (item.ProductId == product.ProductId)
                    {
                        item.ProductName = product.ProductName;
                        item.Stock = product.Stock;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
