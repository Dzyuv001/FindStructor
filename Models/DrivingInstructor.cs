using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FindStructor.Models
{
    public class DrivingInstructor
    {
        public int Id { get; set; }

        public string IdentityId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must be at least 2 characters long.")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Your name seems to be invalid")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must be at least 2 characters long.")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Your name seems to be invalid")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float PricePerLesson { get; set; }


        public Grade Grade { get; set; }


        public byte GradeId { get; set; }


        public byte RatingAvarage { get; set; }
    }
}