using Microsoft.AspNetCore.Mvc;

namespace CW.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
