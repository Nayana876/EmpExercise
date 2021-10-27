using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmpExercise.Data;
using EmpExercise.Models;

namespace EmpExercise.Controllers
{
    public class Emps1Controller : Controller
    {
        private EmpExerciseDBContext db = new EmpExerciseDBContext();

        // GET: Emps1
        public ActionResult Index()
        {
            return PartialView("OurPView",db.Emps.ToList());
        }
       


    }
}
