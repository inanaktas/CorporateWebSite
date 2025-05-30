using Microsoft.AspNetCore.Mvc;

namespace CW.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();

        }
    }
}
