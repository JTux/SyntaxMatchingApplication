using SyntaxMatching.Models.Snippet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Category
{
    public class CategoryDetail
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<SnippetListItem> Snippets { get; set; } = new List<SnippetListItem>();
    }
}