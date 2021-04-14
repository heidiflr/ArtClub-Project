using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data
{
    public class UserCard
    {
        [Key]
        public Guid UserCardID { get; set; }
        public int UserID { get; set; }
        public int CardID { get; set; }
    }
}
