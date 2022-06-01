using Microsoft.AspNetCore.Mvc;
using TimeTracking_Ui.Models;

namespace TimeTracking_Ui.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = "Hi!!!...";
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login login)
        {
            int Id = login.Id;
            string? Name = login.Name;
            return View();
        }
    }
}
