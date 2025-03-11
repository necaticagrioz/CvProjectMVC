using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;
using CvProjectMVC.Models.Entity;
using CvProjectMVC.Reposityory;

namespace CvProjectMVC.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<TblIletisim> repo = new GenericRepository<TblIletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List(); 
            return View(mesajlar);
        }
    }
}