using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Ui.Controllers
{
    public class UserDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetUser(int id)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();

                var listOfUsers = databaseService.GetUser(id);

                return Ok(listOfUsers);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
       
    }
}
