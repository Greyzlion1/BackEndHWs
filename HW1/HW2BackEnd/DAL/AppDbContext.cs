using HW1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
                
        }

        public DbSet<Trainers> Trainers { get; set; }

        public DbSet<Courses> Courses { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Pricing> Pricings { get; set; }

        public DbSet<PlanItem> PlanItems { get; set; }

        public DbSet<PricingPlanItem> pricingPlanItems { get; set; }

        public DbSet<Events>Events { get; set; }

    }
}
