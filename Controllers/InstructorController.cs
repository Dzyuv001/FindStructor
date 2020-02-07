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

        public string GetCurrentUserId()
        {
            return _context.Users.Where(u => u.Email == System.Web.HttpContext.Current.User.Identity.Name).FirstOrDefault().Id;
        }

        // GET: Instructor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccountSetup()
        {
            var grades = _context.Grade.ToList();
            var viewModel = new DrivingInstructorViewModel { Grades = grades };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveInstructorData(DrivingInstructor model)
        {
            if (!ModelState.IsValid)
            {
                return Content("Issue with the data");
            }
            var instructorData = model;
            instructorData.IdentityId = GetCurrentUserId();
            var instructorInDb = new DrivingInstructor
            {
                IdentityId = GetCurrentUserId(),
                FirstName = instructorData.FirstName,
                LastName = instructorData.LastName,
                RegistrationDate = instructorData.RegistrationDate,
                PricePerLesson = instructorData.PricePerLesson,
                GradeId = instructorData.GradeId,
            };
            _context.DrivingInstructors.Add(instructorInDb);
            _context.SaveChanges();
            return Content("Data Saved for Driving Instructor");
        }
    }
}