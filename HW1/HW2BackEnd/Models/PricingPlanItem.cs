using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.Models
{
    public class PricingPlanItem
    {
        public int Id{ get; set; }
        public int PricingId { get; set; }

        public int PlanItemId { get; set; }

        public Pricing Pricing { get; set; }

        public PlanItem PlanItem { get; set; }
    }
}
