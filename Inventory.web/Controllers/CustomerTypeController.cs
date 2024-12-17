using Microsoft.AspNetCore.Mvc;

namespace Inventory.web.Controllers
{
    public class CustomerTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
