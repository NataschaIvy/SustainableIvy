using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SustainableIvy.Controllers
{
    public class HuntingController : Controller
    {
        // GET: Hunting
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hunting/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hunting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hunting/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Hunting/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hunting/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Hunting/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hunting/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}