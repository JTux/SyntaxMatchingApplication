using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SyntaxMatching.Models.Entities;

namespace SyntaxMatching.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Cohort> Cohorts { get; set; }
        public DbSet<CodeCategory> CodeCategories { get; set; }
        public DbSet<CodeSnippet> Snippets { get; set; }
        public DbSet<Submission> Submissions { get; set; }
    }
}