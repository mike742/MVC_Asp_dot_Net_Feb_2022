using Microsoft.AspNetCore.Mvc;
using MVC_Asp_dot_Net_Feb_2022.Data.Interfaces;
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
    }
}
