using Microsoft.AspNetCore.Mvc;

namespace JogoDaMemoria.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
