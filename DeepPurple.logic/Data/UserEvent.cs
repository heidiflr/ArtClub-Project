using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data
{
    public class UserEvent
    {
        [Key]
        public Guid UserEventID { get; set; }
        public Users User { get; set; }
        public Event Event { get; set; }
    }
}
