using Microsoft.AspNetCore.Mvc;
using Warmur.Models;
using System.Collections.Generic;

namespace Warmur.Controllers
{
    public class IndicatorLeadController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
