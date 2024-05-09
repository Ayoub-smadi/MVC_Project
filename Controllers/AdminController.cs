using Microsoft.AspNetCore.Mvc;

namespace Recipe__MVCProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
