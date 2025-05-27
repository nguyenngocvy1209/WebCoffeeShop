using Microsoft.AspNetCore.Mvc;

namespace WebCoffeeShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
