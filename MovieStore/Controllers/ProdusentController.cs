using Microsoft.AspNetCore.Mvc;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class ProdusentController : Controller
    {
        private readonly IProdusentService _produsentService;

        public ProdusentController(IProdusentService produsentService)
        {
            _produsentService = produsentService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
