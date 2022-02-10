using Microsoft.AspNetCore.Mvc;
using MVC_Asp_dot_Net_Feb_2022.Data.Interfaces;
using MVC_Asp_dot_Net_Feb_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Asp_dot_Net_Feb_2022.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorRepo _repo;
        private readonly IProductRepo _produstRepo;

        public VendorController(IVendorRepo repo, IProductRepo productRepo)
        {
            _repo = repo;
            _produstRepo = productRepo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IEnumerable<string> GetProductByVendorCode(int id)
        {
            // linq
            var result = _produstRepo.GetAll()
                .Where(p => p.V_code == id)
                .Select(p => p.P_descript + "\t $" + p.P_Price + "<br>");

            if (result == null || result.Count() == 0)
            {
                return new List<string> { "No product found" }; 
            }

            return result;
        }

        // Get
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Vendor input)
        {
            try
            {
                _repo.Create(input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(_repo.GetById(id));
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Vendor input)
        {
            try
            {
                _repo.Update(id, input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            return View(_repo.GetById(id));
        }

        public ActionResult Delete(int id)
        {
            return View(_repo.GetById(id));
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Vendor vendor)
        {
            try
            {
                _repo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
