using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Rating
{
    public class RatingCreate
    {
        [Required]
        public double Value { get; set; }

        [Required]
        public int SnippetId { get; set; }
    }
}