using SyntaxMatching.Models;
using SyntaxMatching.Models.Entities;
using SyntaxMatching.Models.Rating;
using SyntaxMatching.Models.Snippet;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SyntaxMatching.Services
{
    public class SnippetService
    {
        private readonly ApplicationDbContext _context;
        private readonly string _userId;

        public SnippetService() => _context = new ApplicationDbContext();
        public SnippetService(string userId) : this() => _userId = userId;
        public SnippetService(ApplicationDbContext context) => _context = context;
        public SnippetService(string userId, ApplicationDbContext context) : this(context) => _userId = userId;

        public async Task<List<SnippetListItem>> GetCodeSnippets()
        {
            var snippets = await _context.Snippets.ToListAsync();
            return snippets.Select(s => CreateSnippetListItem(s)).ToList();
        }

        public async Task<List<SnippetListItem>> GetSnippetsByCategory(int categoryId)
        {
            var targetCategory = await _context.CodeCategories.FindAsync(categoryId);
            return targetCategory?.Snippets.Select(s => CreateSnippetListItem(s)).ToList();
        }

        public async Task<SnippetDetail> GetSnippetById(int snippetId)
        {
            var targetSnippet = await _context.Snippets.FindAsync(snippetId);
            return (targetSnippet != null) ? CreateSnippetDetail(targetSnippet) : null;
        }

        internal SnippetListItem CreateSnippetListItem(CodeSnippetEntity entity)
        {
            return new SnippetListItem
            {
                Id = entity.Id,
                CategoryId = entity.CategoryId,
                CategoryName = entity.Category.CategoryName,
                AverageRating = entity.AverageRating
            };
        }

        internal SnippetDetail CreateSnippetDetail(CodeSnippetEntity entity)
        {
            var ratingService = (_userId == null) ? new RatingService(_context) : new RatingService(_userId, _context);

            return new SnippetDetail
            {
                Id = entity.Id,
                AverageRating = entity.AverageRating,
                CategoryId = entity.CategoryId,
                CategoryName = entity.Category.CategoryName,
                Ratings = entity.Ratings.Select(r => ratingService.CreateRatingDetail(r)).ToList(),
            };
        }
    }
}