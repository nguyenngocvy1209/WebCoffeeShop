using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebCoffeeShop.Models;
using WebCoffeeShop.Models.Repository;

namespace WebCoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.GetAllProducts());
        }
    }
}
