using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tra_Luoi.Models;
using System.Security.Policy;
namespace Tra_Luoi.Controllers
{
    public class EmployeesController : Controller
    {
        //GET: Employees

        public ActionResult Recruitment()
        {
            Tra_LuoiDBContext dbContext = new Tra_LuoiDBContext();

            List<Job> jobs = dbContext.Jobs.ToList();

            return View(jobs);
        }
        public ActionResult Employees(int id)
        {
            using (Tra_LuoiDBContext db = new Tra_LuoiDBContext())
            {
                Job_Stores job = db.Job_Stores
                    .Include(x => x.Job)
                    .FirstOrDefault(x => x.Job_Store_ID == id);

                if (job == null)
                {
                    return HttpNotFound();
                }

                return View(job);
            }
        }
    }
}   
