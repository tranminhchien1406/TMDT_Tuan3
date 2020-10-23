using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT_Tuan3.Models;
namespace TMDT_Tuan3.Controllers
{
    public class BannerController : Controller
    {
         TMDTEntities db = new TMDTEntities();
        // GET: Banner
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeaderBanner()
        {
            var headerBanner = db.Banners.Where(c => c.Name == "Header").FirstOrDefault();
            return PartialView(headerBanner);
        }
        public ActionResult LeftBanner()
        {
            var leftBanner = db.Banners.Where(c => c.Name == "Left").FirstOrDefault();
            return PartialView(leftBanner);
        }
        public ActionResult RightBanner()
        {
            var RightBanner = db.Banners.Where(c => c.Name == "Right").FirstOrDefault();
            return PartialView(RightBanner);
        }
    }
}