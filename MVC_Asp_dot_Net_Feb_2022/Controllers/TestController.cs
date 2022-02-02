using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Asp_dot_Net_Feb_2022.Controllers
{
    public class TestController : Controller
    {
        public string Index(int id)
        {
            return "Hello MVC!!! id = " + id;
        }

        public ActionResult Redirect()
        {
            return Redirect("https://google.com");
        }
    }
}
