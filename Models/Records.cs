using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRecords.Models
{
    public class Record
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "The email address is required")]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "The email address is required")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "The email address is required")]
        public string Address { get; set; }
    }
}

