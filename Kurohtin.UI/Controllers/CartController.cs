using Microsoft.AspNetCore.Mvc;

namespace WebAppLB1.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
