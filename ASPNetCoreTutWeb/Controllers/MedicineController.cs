using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreTutWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreTutWeb.Controllers
{
    public class MedicineController : Controller
    {

        List<MedicineModel> medicines = new List<MedicineModel>();

        public MedicineController()
        {
            this.medicines.Add(new MedicineModel("1", "Test Medicine 1", "Test Manufacturer 1", 100.00, new DateTime(2017, 10, 12)));
            this.medicines.Add(new MedicineModel("2", "Test Medicine 2", "Test Manufacturer 2", 200.00, new DateTime(2017, 10, 14)));
            this.medicines.Add(new MedicineModel("3", "Test Medicine 3", "Test Manufacturer 3", 300.00, new DateTime(2017, 10, 15)));
        }


        // GET: Medicine
        public IActionResult Index()
        {
            return View(this.medicines);
        }

        // GET: Medicine/Details/5
        public IActionResult Details(int id)
        {
            MedicineModel medicine = this.medicines.SingleOrDefault(x => x.Id == id.ToString());

            return View(medicine);
        }

        // GET: Medicine/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medicine/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction(nameof(Create));
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Medicine/Edit/5
        public IActionResult Edit(int id)
        {
            MedicineModel medicine = this.medicines.SingleOrDefault(x => x.Id == id.ToString());

            return View(medicine);
        }

        // POST: Medicine/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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

        // GET: Medicine/Delete/5
        public IActionResult Delete(int id)
        {
            MedicineModel medicine = this.medicines.SingleOrDefault(x => x.Id == id.ToString());

            return View(medicine);
        }

        // POST: Medicine/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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