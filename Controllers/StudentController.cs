using FindStructor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindStructor.Controllers
{
    public class StudentController : Controller
    {

        private ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }

        public string GetCurrentUserId()
        {
            return _context.Users.Where(u => u.Email == System.Web.HttpContext.Current.User.Identity.Name).FirstOrDefault().Id;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccountSetup()
        {
            var model = new Student();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveStudentData(Student model)
        {
            if (!ModelState.IsValid)
            {
                return Content("Issue with the data");
            }
            var studentDate = model;
            studentDate.IdentityId = GetCurrentUserId();
            _context.Students.Add(studentDate);
            _context.SaveChanges();
            return RedirectToAction("ProfileEdit", "Student");
        }


        public ActionResult ProfileEdit()
        {
            return View();
        }
    }
}