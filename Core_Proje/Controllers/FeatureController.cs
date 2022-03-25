using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IActionResult Index()
        {
            ViewBag.value = "Öne Çıkanlar Listesi";
            ViewBag.value2 = "Öne Çıkanlar";
            ViewBag.value3 = "Öne Çıkanlar Listesi";
            var values = featureManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddFeature()
        {
            ViewBag.value = "Öne Çıkanlar Ekleme";
            ViewBag.value2 = "Öne Çıkanlar";
            ViewBag.value3 = "Öne Çıkanlar Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            featureManager.TAdd(feature);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFeature(int id)
        {
            var values = featureManager.TGetById(id);
            featureManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            ViewBag.value = "Öne Çıkanlar Güncelleme";
            ViewBag.value2 = "Öne Çıkanlar";
            ViewBag.value3 = "Öne Çıkanlar Güncelleme";
            var values = featureManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }
    }
}
