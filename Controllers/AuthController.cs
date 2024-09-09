using Microsoft.AspNetCore.Mvc;

namespace Dev_backend.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
