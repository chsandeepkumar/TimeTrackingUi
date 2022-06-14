using Microsoft.AspNetCore.Mvc;
using TimeTracking_Ui.Models;

namespace TimeTracking_Ui.Controllers
{

    public class LoginController : Controller
    {
       // SessionState(SessionStateBehavior.Default)] 
        public IActionResult Index()
        {
         //   ViewBag.message = "Hi!!!...";
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(Login login)
        {
            

            try
            {
                DatabaseService databaseService = new DatabaseService();

                var isSuccess = databaseService.UserLogin(login);
                if (isSuccess)
                {
                    ViewBag.message = "Please enter your role..";
                    return View("../Role/Index");
                }
                else
                {
                    ViewBag.message = "Please enter valid user details";
                    return View("../Login/Index");
                }
            
            }
           
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
