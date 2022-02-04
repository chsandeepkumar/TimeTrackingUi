using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Ui.Controllers
{
    public class TimeTrackingController : Controller
    {
        // GET: TimeTrackingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TimeTrackingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeTrackingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeTrackingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TimeTrackingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeTrackingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TimeTrackingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeTrackingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
