using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FindStructor.Models
{
    public class Grade
    {
        public byte Id { get; set; }

        [StringLength(2, MinimumLength = 1, ErrorMessage = "field must be at least 1 characters")]
        public string Name { get; set; } 
    }
}