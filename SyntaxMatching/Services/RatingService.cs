using SyntaxMatching.Models;
using SyntaxMatching.Models.Entities;
using SyntaxMatching.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SyntaxMatching.Services
{
    public class RatingService
    {
        private readonly ApplicationDbContext _context;
        private readonly string _userId;

        public RatingService() => _context = new ApplicationDbContext();
        public RatingService(string userId) : this() => _userId = userId;
        public RatingService(ApplicationDbContext context) => _context = context;
        public RatingService(string userId, ApplicationDbContext context) : this(context) => _userId = userId;

        public async Task<bool> CreateRating(RatingCreate model)
        {
            var targetSnippet = await _context.Snippets.FindAsync(model.SnippetId);
            if (targetSnippet != null)
            {
                var rating = new RatingEntity { SnippetId = model.SnippetId, Value = model.SnippetId, UserId = _userId };
                _context.Ratings.Add(rating);
            }

            return await _context.SaveChangesAsync() == 1;
        }


        internal RatingDetail CreateRatingDetail(RatingEntity entity)
        {
            return new RatingDetail
            {
                Id = entity.Id,
                Value = entity.Value,
                IsUserOwned = entity.UserId == _userId
            };
        }
    }
}