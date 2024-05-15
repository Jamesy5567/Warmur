using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Warmur.Models
{
    public class IndicatorLead
    {
        public List<Indicator> Indicator {get; set;}
        public Lead Lead {get; set;}
    }
}