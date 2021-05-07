using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DeepPurple.ApplicationLogic.Data
{
    public class Resource
    {
        [Key]
        public Guid ResourceID { get; set; }
        public string ResourceName { get; set; }
        public string ResourceDescription { get; set; }
        public int ResourcePrice { get; set; }
    }
}
