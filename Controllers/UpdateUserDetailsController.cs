using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Ui.Controllers
{
    public class UpdateUserDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPut]
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
    }
}
