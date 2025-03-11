using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProjectMVC.Models.Entity;
using CvProjectMVC.Reposityory;

namespace CvProjectMVC.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim

        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeneyimEkle(TblDeneyim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeneyimSil(int id)
        {
            TblDeneyim t = repo.Find(x=>x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            TblDeneyim t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(TblDeneyim p)
        {
            TblDeneyim t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.Altbaslik = p.Altbaslik;
            t.Aciklama = p.Aciklama;
            t.Tarih = p.Tarih;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}