using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerProject.Models
{
    public class Tovar
    {
        [Key]
        public int ItemCode { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Balance { get; set; }
        public string Image { get; set; }
    }
}
