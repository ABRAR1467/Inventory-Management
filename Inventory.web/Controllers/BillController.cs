using Microsoft.AspNetCore.Mvc;

namespace Inventory.web.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
