using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warmur.Models
{
    public class Indicator
    {
        public int Id { get; set; }
        public int LeadId { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public int Value { get; set; }
    }
}