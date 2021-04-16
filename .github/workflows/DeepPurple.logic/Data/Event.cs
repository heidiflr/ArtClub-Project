using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data
{
    public class Event
    {
        [Key]
        public Guid EventID { get; set; }
        public char Name { get; set; }
        public char Description { get; set; }
        public DateTime Date { get; set; }
       
    }
}
