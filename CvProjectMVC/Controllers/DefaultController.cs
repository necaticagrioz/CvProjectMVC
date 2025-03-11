using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CvProjectMVC.Models.Entity;

namespace CvProjectMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCVEntities db = new DbCVEntities();
        public ActionResult Index()
        {

            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitim()
        {
            var egitimler = db.TblEgitim.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yetenek()
        {
            var yetenekler = db.TblYetenek.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobi()
        {
            var hobiler = db.TblHobiler.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifika()
        {
            var sertifika = db.TblSertifika.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
           
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(TblIletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblIletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}