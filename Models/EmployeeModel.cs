using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validations_DataAnnotations.Models
{
    public class EmployeeModel
    {
        [Display(Name ="Full Name:")]
        [Required(ErrorMessage ="Full Name is required.")]
        public string FullName { get; set; }
        [Display(Name = "Date of Birth:")]
        [Required(ErrorMessage =   "Date Of Birth is required.")]

        //[DataType(DataType.Date)]
        //[DataType(DataType.Time)]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email is required")]



        public string Email { get; set; }
        [Display(Name = "Mobile:")]
        [Required]

        public string Mobile { get; set; }
        [Display(Name = "Address:")]

        public string Address { get; set; }
        [Display(Name = "Salary:")]

        public decimal? Salary { get; set; }
        [Display(Name = "Website:")]

        public string Website { get; set; }
    }
}
