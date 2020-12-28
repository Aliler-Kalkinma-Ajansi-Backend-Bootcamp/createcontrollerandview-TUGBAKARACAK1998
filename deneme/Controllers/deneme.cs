using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Controllers
{
    public class deneme : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ornek()
        {
            return View();
        }
    }
}
