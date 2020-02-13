using SyntaxMatching.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Snippet
{
    public class SnippetDetail
    {
        public int Id { get; set; }
        public string SnippetName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double? AverageRating { get; set; }
        public List<RatingDetail> Ratings { get; set; } = new List<RatingDetail>();
    }
}