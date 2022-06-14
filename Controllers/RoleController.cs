using Microsoft.AspNetCore.Mvc;
using TimeTracking_Ui.Models;

namespace TimeTracking_Ui.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.message = "What is your Role";
            return View();
        }


    }


}
