using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data

{
    public class Resource
    {
        public Guid ResourceID { get; set; }
        public string ResourceName { get; set; }
        public string ResDescription { get; set; }
        public int ResPrice { get; set; }
        //public ??? ResourcePic { get; set; }
        
    }
}
