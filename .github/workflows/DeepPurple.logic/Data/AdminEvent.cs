using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data
{
    public class AdminEvent
    {
        public Guid AdminEventID { get; set; }
        public Guid AdminID { get; set; }
        public Guid EventID { get; set; }
        
    }
}
