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
    }
}
