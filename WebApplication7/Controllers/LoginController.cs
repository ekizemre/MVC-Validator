using emreekiz.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;



namespace emreekiz.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        
        ASTOR2Entities db = new ASTOR2Entities();
        [Authorize]
        public ActionResult Index()
        {
            var deger = db.TB_Admin.ToList();
            return View(deger);
        }
       
    }
}