using Microsoft.AspNetCore.Mvc;

namespace Vue.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
