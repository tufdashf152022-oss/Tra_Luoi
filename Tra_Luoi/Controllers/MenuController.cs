using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Tra_Luoi.Models;

namespace Tra_Luoi.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Caphe(int categoryId = 1)
        {
            Tra_LuoiDBContext dBContext = new Tra_LuoiDBContext();
            List<Product> Listproducts = dBContext.Products.Include(cat => cat.Category).Where(pro => pro.CatID == categoryId).ToList();
            return View(Listproducts);
        }
        public ActionResult epdau(int categoryId = 2)
        {
            Tra_LuoiDBContext dBContext = new Tra_LuoiDBContext();
            List<Product> Listproducts = dBContext.Products.Include(cat => cat.Category).Where(pro => pro.CatID == categoryId).ToList();
            return View(Listproducts);
        }
        public ActionResult epdautam(int categoryId = 3)
        {
            Tra_LuoiDBContext dBContext = new Tra_LuoiDBContext();
            List<Product> Listproducts = dBContext.Products.Include(cat => cat.Category).Where(pro => pro.CatID == categoryId).ToList();
            return View(Listproducts);
        }       
        public ActionResult sinhtobo(int categoryId = 4)
        {
            Tra_LuoiDBContext dBContext = new Tra_LuoiDBContext();
            List<Product> Listproducts = dBContext.Products.Include(cat => cat.Category).Where(pro => pro.CatID == categoryId).ToList();
            return View(Listproducts);
        }
        public ActionResult trasua(int categoryId = 5)
        {
            Tra_LuoiDBContext dBContext = new Tra_LuoiDBContext();
            List<Product> Listproducts = dBContext.Products.Include(cat => cat.Category).Where(pro => pro.CatID == categoryId).ToList();
            return View(Listproducts);
        }
        public ActionResult travaivixa(int categoryId = 6)
        {
            Tra_LuoiDBContext dBContext = new Tra_LuoiDBContext();
            List<Product> Listproducts = dBContext.Products.Include(cat => cat.Category).Where(pro => pro.CatID == categoryId).ToList();
            return View(Listproducts);
        }
    }
}