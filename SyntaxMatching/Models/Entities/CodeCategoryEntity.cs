using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Entities
{
    public class CodeCategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public virtual ICollection<CodeSnippetEntity> Snippets { get; set; }
    }
}