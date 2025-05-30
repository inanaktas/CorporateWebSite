using Microsoft.AspNetCore.Mvc;

namespace CW.WebUI.Areas.Admin.Controllers
{
    public class FeedbackController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
