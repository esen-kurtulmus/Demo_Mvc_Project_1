using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Mvc_Project_1.Models;

namespace Demo_Mvc_Project_1.Controllers
{
    
    public class HastaneController : Controller
    {
        HastaneProjeEntities db = new HastaneProjeEntities();
        public ActionResult BransList()
        {
            var values = db.Tbl_Branslar.ToList();
            return View(values);
        }
        public ActionResult HastaList()
        {
            var values =db.Tbl_Hastalar.ToList();
            return View(values);
        }
    }
}