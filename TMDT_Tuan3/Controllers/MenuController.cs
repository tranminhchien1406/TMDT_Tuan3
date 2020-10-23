using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT_Tuan3.Models;

namespace TMDT_Tuan3.Controllers
{
    public class MenuController : Controller
    {
        TMDTEntities db = new TMDTEntities();
        // GET: Menu
        public ActionResult Index()
        {
            var menus = db.Menus;
            return PartialView(menus);
        }
    }
}