using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.Models
{
    public class AddEventViewModel
    {
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventLocation { get; set; }
        public DateTime EventDateTime { get; set; }
        public DeepPurple.ApplicationLogic.Data.Users Organiser { get; set; }
        public ICollection<DeepPurple.ApplicationLogic.Data.Users> Invitees { get; set; }
    } 
}
