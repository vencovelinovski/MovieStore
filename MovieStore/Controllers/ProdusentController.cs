using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class ProdusentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
