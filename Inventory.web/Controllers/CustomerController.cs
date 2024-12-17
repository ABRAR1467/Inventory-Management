using Microsoft.AspNetCore.Mvc;

namespace Inventory.web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
