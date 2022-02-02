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
        private readonly IVendor _repo;

        public VendorController(IVendor repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
    }
}
