using emreekiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emreekiz.Controllers
{
    public class SoforlerController : Controller
    {
        // GET: Soforler
        ASTOR2Entities db=new ASTOR2Entities();
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
        public ActionResult Ekle(TB_şoförler yenisof)
        {
            db.TB_şoförler.Add(yenisof);
            db.SaveChanges();

            return View();
        }

        public ActionResult SoforListe()
        {

            var sonuc = db.TB_şoförler.ToList();

            return View(sonuc);
        }

       
        [HttpGet]
        public ActionResult Sil()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sil(int id)
        {
            
            var silinecekSoförler = db.TB_şoförler.Find(id);
            db.TB_şoförler.Remove(silinecekSoförler);
            db.SaveChanges();
            return RedirectToAction("SoforListe");   

        }
      
        
    }
}