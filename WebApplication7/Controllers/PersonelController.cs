using emreekiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emreekiz.Controllers
{
    public class PersonelController : Controller
    {
        ASTOR2Entities db = new ASTOR2Entities();

        // GET: Personel
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(TB_Personel yenip)
        {
            db.TB_Personel.Add(yenip);
            db.SaveChanges();

            return View();
        }

        public ActionResult Liste()
        {

            var sonuc = db.TB_Personel.ToList();

            return View(sonuc);
        }

        [HttpGet]
        public ActionResult Ara()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ara(TB_Personel frmgelen)
        {
            var sonuc = db.TB_Personel.Where(x => (x.PersonelAd.Contains(frmgelen.PersonelAd) || x.PersonelSoyad.Contains(frmgelen.PersonelSoyad))).ToList();
            return View("Liste", sonuc);
        }
        [HttpGet]
        public ActionResult Sil()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sil(int id)
        {
            var silinecekPersonel = db.TB_Personel.Find(id);
            db.TB_Personel.Remove(silinecekPersonel);
            db.SaveChanges();
            return RedirectToAction("Liste");

        }
        
        
       


    }
    
}


