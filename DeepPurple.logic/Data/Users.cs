using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.ApplicationLogic.Data
{
    public class Users
    {
        [Key]
        public Guid userID { get; set; }
        public char Username { get; set; }
        public char Password { get; set; }
        public char Email { get; set; }
        public bool Member { get; set; }
        // public ??? ProfilePic { get; set;}
    }
}
