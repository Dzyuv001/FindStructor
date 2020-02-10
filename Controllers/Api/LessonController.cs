using FindStructor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FindStructor.Controllers.Api
{
    public class LessonController : ApiController
    {
        private ApplicationDbContext _context;

        public LessonController()
        {
            _context = new ApplicationDbContext();
        }

        //get /api/LessonType
        public IHttpActionResult GetLessonTypes(string query = null) {
            return Ok();
        }

        //Post api/LessonType
        [HttpPost]
        public IHttpActionResult CreateNewLessonType() {
            return Ok();
        }

        //Put api/LessonType
        [HttpPut]
        public IHttpActionResult UpdateLessonType(string Id) {
            return Ok();
        }

        //Delete api/LessonType/Id
        [HttpDelete]
        public void DeleteLessonTypes(string Id) {

    
        }
    }
}
