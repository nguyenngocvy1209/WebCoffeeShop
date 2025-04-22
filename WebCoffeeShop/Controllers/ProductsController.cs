using Microsoft.AspNetCore.Mvc;
using WebCoffeeShop.Models.Repository;

namespace WebCoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
       private IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            return View(productRepository.GetAllProducts());
        }
    }
}
