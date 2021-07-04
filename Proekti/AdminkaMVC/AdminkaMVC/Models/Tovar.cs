using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdminkaMVC.Models
{
    public class Tovar
    {
        [Key]
        public int ItemCode { get; set; }
        public string Company { get; set; }
        [Required(ErrorMessage = "Нет имени")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Нет описания")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Не указана цена")]
        [Range(1, 100000, ErrorMessage = "Недопустимая цена")]

        public int Price { get; set; }
        public int Balance { get; set; }
        public string Image { get; set; }

    }
}
