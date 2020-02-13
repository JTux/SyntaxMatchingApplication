using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SyntaxMatching.Models.Entities;

namespace SyntaxMatching.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationDbContext : IdentityDbContext<UserEntity>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<CohortEntity> Cohorts { get; set; }
        public DbSet<CodeCategoryEntity> CodeCategories { get; set; }
        public DbSet<CodeSnippetEntity> Snippets { get; set; }
        public DbSet<SubmissionEntity> Submissions { get; set; }
        public DbSet<RatingEntity> Ratings { get; set; }
    }
}