using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warmur.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string Location { get; set; }
    }
}