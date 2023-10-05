using Microsoft.AspNetCore.Mvc;

namespace YetGenAkbankJump.MVCClient.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
