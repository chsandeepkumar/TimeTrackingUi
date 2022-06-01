using Microsoft.AspNetCore.Mvc;
using TimeTracking_Ui.Models;

namespace TimeTracking_Ui.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = "What is your Role";
            return View();
        }

        [HttpPost]
        public ActionResult Index(Role role)
        {
            int Roleid = role.Roleid;
            string? RoleName = role.RoleName;
            string? RoleDescription = role.RoleDescription;
            DateTime CreatedDateTime = role.CreatedDateTime;
            DateTime UpdatedDateTime = role.UpdatedDateTime;
            return View();
        }


    }


}
