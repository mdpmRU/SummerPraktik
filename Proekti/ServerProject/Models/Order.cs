    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerProject.Models
{
    public class Order
    {
        [Key]
        public int OrderCode { get; set; }
        public int ItemCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string Order_date { get; set; }
    }
}
