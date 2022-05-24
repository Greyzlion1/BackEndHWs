using HW1.DAL;
using HW1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.Controllers
{
    public class TrainersController : Controller
    {
        private readonly AppDbContext _context;
        public TrainersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Trainers> trainers = _context.Trainers.Include(t=>t.Position).ToList();

            return View(trainers);
        }
    }
}
