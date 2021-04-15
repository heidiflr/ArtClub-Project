using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.Models
{
    public class AddResourceViewModel
    {
        public Guid ResourceID { get; set; }
        public string ResourceName { get; set; }
        public string ResDescription { get; set; }
        public int ResPrice { get; set; }
    }
}
