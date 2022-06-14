using Microsoft.AspNetCore.Mvc;
using TimeTracking_Ui.Models;

namespace TimeTracking_Ui.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserLogout(string name)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                Logout logout= new Logout { Name = name };
                var isSuccess = databaseService.UserLogout(logout);
                if (isSuccess)
                {
                    ViewBag.message = "Logout Successful...";
                    return View("../UserRegistration/Index");
                }
                else
                {
                    return View("Error");
                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
