using Microsoft.AspNetCore.Mvc;

namespace WebAppLB1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
