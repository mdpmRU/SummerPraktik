using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdminkaMVC.Models
{
    public class Order
    {
        [Key]
        public int OrderCode { get; set; }
        public int ItemCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Не указан адрес")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 50 символов")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Не указано количество")]
        [Range(1, 1000, ErrorMessage = "Недопустимое количество")]

        public int Quantity { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string Order_date { get; set; }


    }
}
