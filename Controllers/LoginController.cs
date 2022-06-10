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
        public IActionResult UserLogin(Login login)
        {
            

            try
            {
                DatabaseService databaseService = new DatabaseService();

                var isSuccess = databaseService.UserLogin(login);

                return Redirect("Role"); 

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
