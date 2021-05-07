using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DeepPurple.ApplicationLogic.Data
{
    public class Admin
    {
        [Key]
        public Guid AdminID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
