using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DeepPurple.ApplicationLogic.Data
{
    public class Brandmark
    {
        [Key]
        public Guid BrandMarkID { get; set; }
        public bool MaterCard { get; set; }
        public bool Visa { get; set; }
        public bool PayPal { get; set; }
    }
}
