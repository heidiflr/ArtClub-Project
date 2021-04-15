using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data
{
    public class ResourceEvent
    {
        public Guid ResourceEventID { get; set; }
        public Guid EventID { get; set; }
        public Guid ResourceID { get; set; }
    }
}
