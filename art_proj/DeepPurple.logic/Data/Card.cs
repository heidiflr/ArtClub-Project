using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data
{
    public class Card
    {
        [Key]
        public Guid CardID { get; set; }
        public int AccNumber { get; set; }
        public int CVV { get; set; }
        public char CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int BrandMark { get; set; }
    }
}
