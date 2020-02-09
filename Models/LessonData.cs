using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindStructor.Models
{
    public class LessonData
    {
        public long Id { get; set; }
        public bool IsBasePrice { get; set; }

        //used to check if the value should be displayed 
        public bool IsUnlisted { get; set; }

        [Display(Name = "Lesson Title")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Discount name must be at least 5 to 30 characters")]
        public string Name { get; set; }


        [Range(0, 300, ErrorMessage = "The length of lesson(s) has to be between {1} to {2}")]
        public short LessonLength { get; set; }

        [Display(Name = "Price for Lesson(s)")]
        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public float Price { get; set; }

        [Display(Name = "Number of Lessons")]
        [Range(0, 100, ErrorMessage = "The number of lessons has to be between {1} to {2}")]
        public short NumberOfLessons { get; set; }


        [DisplayFormat(DataFormatString = "{0:#.####}")]
        public float? Saving { get; set; }
    }
}