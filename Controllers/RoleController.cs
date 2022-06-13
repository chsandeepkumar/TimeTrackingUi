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

        [HttpPost]
        //public ActionResult Index(Role role)
        //{
        //    try
        //    {
        //        DatabaseService databaseService = new DatabaseService();

        //        var isSuccess = databaseService.UserRole(role);
        //        if (isSuccess)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            ViewBag.message = "Please enter valid role details..";
        //            return View("../Role/Index");
        //        }

        //    }

        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    };
        //}


    }


}
