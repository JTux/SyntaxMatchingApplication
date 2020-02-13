using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Entities
{
    public class CodeSnippet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string AnswerCSV { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual CodeCategory Category { get; set; }
    }
}