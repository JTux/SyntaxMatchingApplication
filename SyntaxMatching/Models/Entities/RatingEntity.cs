using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Entities
{
    public class RatingEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public int SnippetId { get; set; }

        [ForeignKey(nameof(SnippetId))]
        public virtual CodeSnippetEntity Snippet { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual UserEntity User { get; set; }
    }
}