using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindStructor.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }

        [Required]
        [Display(Name = "First name")]
        [StringLength(20, ErrorMessage = "The {0} length can't be larger than {1} characters.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(30, ErrorMessage = "The {0} length can't be larger than {1} characters.")]

        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(30, ErrorMessage = "The {0} length can't be larger than {1} characters.")]

        public string StreetAddress { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} length can't be larger than {1} characters.")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postcode")]
        [RegularExpression(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})", ErrorMessage = "Please enter a valid postcode eg. FK16 6HU")]
        public string Postcode { get; set; }
    }
}