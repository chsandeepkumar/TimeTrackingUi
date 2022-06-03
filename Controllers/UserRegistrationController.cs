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
      
        public IActionResult SaveUser(UserRegistration userRegistration)
        {

            try
            {
                DatabaseService databaseService = new DatabaseService();

                var numberOfRecordsUpdated = databaseService.SaveUser(userRegistration);

                return Ok(numberOfRecordsUpdated);

            }
            catch (Exception ex)
            {

                throw ex;
            }

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
