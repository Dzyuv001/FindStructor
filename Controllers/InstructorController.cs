using FindStructor.Models;
using FindStructor.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindStructor.Controllers
{
    public class InstructorController : Controller
    {

        private ApplicationDbContext _context;

        public InstructorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Instructor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccountSetup()
        {
            var grades = _context.Grade.ToList();
            var viewModel = new DrivingInstructorViewModel {Grades = grades };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveInstructorData(DrivingInstructor model)
        {
            return Content("Data Saved for Driving Instructor");
        }
    }
}