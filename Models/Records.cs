using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRecords.Models
{
    public class Record
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "A name is required.")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [PhoneAttribute]
        public string Phone { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "An address is required.")]
        public string Address { get; set; }
    }
}

