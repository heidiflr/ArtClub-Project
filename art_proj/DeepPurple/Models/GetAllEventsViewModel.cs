using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeepPurple.ApplicationLogic.Data;

namespace DeepPurple.Models
{
    public class GetAllEventsViewModel
    {
        public IEnumerable<Event> Event { get; set; } 
    }
}
