using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Entities
{
    public class SubmissionEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double PercentCorrect { get; set; }

        [Required]
        public DateTimeOffset SubmissionDate { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual UserEntity User { get; set; }

        [Required]
        public int CodeSnippetId { get; set; }

        [ForeignKey(nameof(CodeSnippetId))]
        public virtual CodeSnippetEntity CodeSnippet { get; set; }
    }
}