using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PrbController : Controller
    {
        // GET: Prb
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prb/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prb/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prb/Create
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

        // GET: Prb/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prb/Edit/5
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

        // GET: Prb/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prb/Delete/5
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