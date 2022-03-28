using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.value = "Dashboard";
            ViewBag.value2 = "İstatistikler";
            ViewBag.value3 = "İstatistik Sayfası";
            return View();
        }
    }
}
