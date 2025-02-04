using Microsoft.AspNetCore.Mvc;

namespace AspCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}