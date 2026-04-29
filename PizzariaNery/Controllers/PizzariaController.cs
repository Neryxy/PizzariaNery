using Microsoft.AspNetCore.Mvc;

namespace PizzariaNery.Controllers
{
    public class PizzariaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
