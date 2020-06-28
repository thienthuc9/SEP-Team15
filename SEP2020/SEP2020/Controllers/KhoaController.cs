using SEP2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEP2020.Areas.SEP.Controllers
{
    public class KhoaController : Controller
    {
        SEP2020Entities model = new SEP2020Entities();
        // GET: SEP/Khoa
        [Authorize]
        public ActionResult Index()
        {
            var khoa = model.Faculties.OrderByDescending(x => x.id).ToList();
            return View(khoa);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var khoa = model.Faculties.FirstOrDefault(x => x.id == id);
            return View(khoa);
        }
        [HttpPost]
        public ActionResult Edit(int id, Faculty f)
        {
            var khoa = model.Faculties.FirstOrDefault(x => x.id == id);

            khoa.Name = f.Name;
    

            model.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Faculty f)
        {
            var khoa = new Faculty();

            khoa.Name = f.Name;

            model.Faculties.Add(khoa);
            model.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var khoa = model.Faculties.FirstOrDefault(x => x.id == id);
            return View(khoa);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var khoa = model.Faculties.FirstOrDefault(x => x.id == id);
            model.Faculties.Remove(khoa);
            model.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}