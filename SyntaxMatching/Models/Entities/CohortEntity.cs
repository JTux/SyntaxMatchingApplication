using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SyntaxMatching.Models.Entities
{
    public class CohortEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cohort Name")]
        public string Name { get; set; }

        public virtual ICollection<UserEntity> Members { get; set; }
    }
}