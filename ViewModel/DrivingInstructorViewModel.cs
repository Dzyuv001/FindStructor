using FindStructor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindStructor.ViewModel
{
    public class DrivingInstructorViewModel
    {
        public int? Id { get; set; }

        public string IdentityId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Qualified as instructor")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [Display(Name = "Price per Lesson")]
        [DataType(DataType.Currency)]
        public float PricePerLesson { get; set; }

        public IEnumerable<Grade> Grades { get; set; }

        [Required]
        [Display(Name = "Grade")]
        public byte GradeId { get; set; }


        public byte RatingAvarage { get; set; }

        public DrivingInstructorViewModel(DrivingInstructor drivingInstructor)
        {
            Id = drivingInstructor.Id;
            FirstName = drivingInstructor.FirstName;
            LastName = drivingInstructor.LastName;
            RegistrationDate = drivingInstructor.RegistrationDate;
            PricePerLesson = drivingInstructor.PricePerLesson;
            GradeId = drivingInstructor.GradeId;
        }

        public DrivingInstructorViewModel() { }

    }
}