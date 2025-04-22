namespace WebCoffeeShop.Models.Repository
{
    public interface IProductRepository
    {
        
            IEnumerable<Product> GetAllProducts();
            IEnumerable<Product> GetTrendingProducts();
            Product GetProductDetail(int id);
        
    }
}
