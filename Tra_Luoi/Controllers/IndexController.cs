using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tra_Luoi.Models;

namespace Tra_Luoi.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Disan()
        {
            return View();
        }
        public ActionResult Menu()
        {
            using (Tra_LuoiDBContext db = new Tra_LuoiDBContext())
            {
                List<Product> products = db.Products.ToList();

                return View(products);
            }
        }
        public ActionResult NewPromotion()
        {
            return View();
        }
        public ActionResult Store()
        {
            return View(); 
        }
        public ActionResult Recruiment()
        {
            var db = new Tra_LuoiDBContext();
            List<Job_Stores> jobs = db.Job_Stores.ToList();
            return View(jobs);
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult Employees()
        {
            return View();
        }
    }
}