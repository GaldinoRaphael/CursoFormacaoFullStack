using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiqueAtivo.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult IndeX() {
            return View();
        }
    }
}
