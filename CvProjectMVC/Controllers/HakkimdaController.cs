using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProjectMVC.Models.Entity;
using CvProjectMVC.Reposityory;

namespace CvProjectMVC.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        DbCVEntities db = new DbCVEntities();
        GenericRepository<TblHakkimda> repo = new GenericRepository<TblHakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();

            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkimda p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Mail = p.Mail;
            t.Telefon = p.Telefon;
            t.Adres = p.Adres;
            t.Aciklama = p.Aciklama;
            t.Resim = p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");

        }

    }
}