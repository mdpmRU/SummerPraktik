using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminkaMVC.Models
{
    public class Users
    {

        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }


    }
}
