using Microsoft.AspNet.Identity;
using NguyenVanThuan_lab456.DTOs;
using NguyenVanThuan_lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenVanThuan_lab456.Controllers.Api
{
    public class CourseController : ApiController
    {
        public ApplicationDbContext _dbcontext { get; set; }
        public CourseController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbcontext.Courses.Single(c => c.ID == id && c.LecturerId == userId);
            if (course.IsCanceled)
                return NotFound();
            course.IsCanceled = true;
            _dbcontext.SaveChanges();
            return Ok();
        }

        public IHttpActionResult UnCancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbcontext.Courses.Single(c => c.ID == id && c.LecturerId == userId);
            if (!course.IsCanceled)
                return NotFound();
            course.IsCanceled = false;
            _dbcontext.SaveChanges();
            return Ok();
        }
    }
}
