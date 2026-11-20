
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tra_Luoi.Models;

namespace Tra_Luoi.Controllers
{
    public class RecruitmentController : Controller
    {
        // GET: Recruitment
        public ActionResult Recruiment()
        {
            var db = new Tra_LuoiDBContext();

            List<Job_Stores> jobs = db.Job_Stores.ToList();

            return View(jobs);
        }
    }
}
