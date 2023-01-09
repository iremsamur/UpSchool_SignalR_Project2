using Microsoft.AspNetCore.Mvc;

namespace UpSchool_Electric_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
