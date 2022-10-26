using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BecauseICan : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}