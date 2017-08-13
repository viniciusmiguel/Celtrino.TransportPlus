using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Celtrino.TransportPlus.Web.Controllers
{
    public class VehicleManufacturerController : Controller
    {
        // GET: VehicleManufacturer
        public ActionResult Index()
        {
            return View();
        }

        // GET: VehicleManufacturer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehicleManufacturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleManufacturer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleManufacturer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehicleManufacturer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleManufacturer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleManufacturer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}