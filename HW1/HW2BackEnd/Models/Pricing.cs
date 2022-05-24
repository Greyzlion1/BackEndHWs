using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.Models
{
    public class Pricing
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool Advanced { get; set; }

        public List<PricingPlanItem> PricingPlanItems { get; set; }
    }
}
