using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepPurple.Models
{
    public class GetAllUsersViewModel
    {
        public IEnumerable<Users> Users { get; set; }

    }
}
