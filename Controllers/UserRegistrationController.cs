using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Ui.Controllers
{
    public class UserRegistrationController : Controller
    {
        //GET 
        public ActionResult Index()
        {

            ViewBag.message = "WELCOME";
            
            return View();

        }

        [HttpPost]
      
        public ActionResult Index(UserRegistration userRegistration)
        {
            
            int Id = userRegistration.Id;
            DateTime CreatedDateTime = userRegistration.CreatedDateTime;
            DateTime UpdatedDateTime = userRegistration.UpdatedDateTime;
            string? Name = userRegistration.Name;
            string? EmailAddress = userRegistration.EmailAddress;
            string? FirstName = userRegistration.FirstName;
            string LastName = userRegistration.LastName;
            int RoleId = userRegistration.RoleId;
            return View();
        }

        //GET: UserRegistrationController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UserRegistrationController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserRegistrationController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UserRegistrationController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
