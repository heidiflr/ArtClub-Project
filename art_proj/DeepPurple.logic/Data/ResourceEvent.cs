using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DeepPurple.ApplicationLogic.Data
{
    public class ResourceEvent
    {
        [Key]
        public Guid ResourceEventID { get; set; }
        public Guid EventID { get; set; }
        public Guid ResourceID { get; set; }
    }
}
