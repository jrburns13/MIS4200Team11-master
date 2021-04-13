using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team11.Models
{
    public class Profile
    {
        [Required]
        public Guid profileId { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        [Required]
        [Display(Name = "Office")]
        public string office { get; set; }

        [Required]
        [Display(Name = "Current Position")]
        public string position { get; set; }

        [Required]
        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime hireDate { get; set; }
    }
}