using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DeepPurple.ApplicationLogic.Data
{
    public class AdminEvent
    {
        [Key]
        public Guid AdminEventID { get; set; }
        public Guid AdminID { get; set; }
        public Guid EventID {get; set;}
    }
}
