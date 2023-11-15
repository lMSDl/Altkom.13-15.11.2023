using ShoppingList.Models;

namespace ShoppingList.Services
{
    public class ProductsService
    {
        private List<Product> _products;

        public ProductsService()
        {
            _products = new List<Product>();
        }

        public Product[] GetProducts()
        {
            return _products.ToArray();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProductAt(int index) {
            if (index >= _products.Count || index < 0)
                return;

            _products.RemoveAt(index);
        }
    }
}
