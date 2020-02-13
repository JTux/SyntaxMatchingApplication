using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Snippet
{
    public class SnippetListItem
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public double? AverageRating { get; set; }
    }
}