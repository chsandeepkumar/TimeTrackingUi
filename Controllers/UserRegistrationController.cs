﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracking_Ui.Controllers
{
    public class UserRegistrationController : Controller
    {
        // GET: UserRegistrationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserRegistrationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserRegistrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserRegistrationController/Create
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

        // GET: UserRegistrationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserRegistrationController/Edit/5
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

        // GET: UserRegistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserRegistrationController/Delete/5
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
