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
        [HttpPost]
        public IActionResult UpdateUser(UserRegistration userRegistration)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var updatedUser = databaseService.UpdateUser(userRegistration);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                DatabaseService databaseService = new DatabaseService();
                var updatedUser = databaseService.DeleteUser(id);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
