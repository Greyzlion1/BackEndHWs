using HW1.DAL;
using HW1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Courses> courses = _context.Courses.ToList();

            return View(courses);
        }
    }
}
