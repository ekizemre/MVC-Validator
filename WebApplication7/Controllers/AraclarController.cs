using emreekiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emreekiz.Controllers
{
    public class AraclarController : Controller
    {
        // GET: Araclar
        ASTOR2Entities1 db = new ASTOR2Entities1();
        public ActionResult AracDetay(int?  id)
        {
            var sonuc = db.TB_Araclar.Where(x => x.AracID == id);
            return View(sonuc);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(TB_Araclar yeniarac)
        {
            db.TB_Araclar.Add(yeniarac);
            db.SaveChanges();

            return View();
        }

        public ActionResult Liste()
        {

            var sonuc = db.TB_Araclar.ToList();
            return View("Liste", sonuc);
        }

        public ActionResult Aractur()
        {
            var sonuc = db.TB_Araclar.ToList();
            return View(sonuc);
        }


    }
}
