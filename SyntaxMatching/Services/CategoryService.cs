using SyntaxMatching.Models;
using SyntaxMatching.Models.Category;
using SyntaxMatching.Models.Entities;
using SyntaxMatching.Models.Snippet;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SyntaxMatching.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService() => _context = new ApplicationDbContext();
        public CategoryService(ApplicationDbContext context) => _context = context;

        public async Task<List<CategoryListItem>> GetCategories()
        {
            var categories = await _context.CodeCategories.ToListAsync();
            return categories.Select(c => CreateCategoryListItem(c)).ToList();
        }

        public async Task<CategoryDetail> GetCategoryById(int categoryId)
        {
            var targetCategory = await _context.CodeCategories.FindAsync(categoryId);
            return (targetCategory != null) ? CreateCategoryDetail(targetCategory) : null;
        }


        internal CategoryListItem CreateCategoryListItem(CodeCategoryEntity entity)
        {
            var snippetService = new SnippetService(_context);

            return new CategoryListItem
            {
                Id = entity.Id,
                CategoryName = entity.CategoryName,
                Snippets = entity.Snippets.Select(s => snippetService.CreateSnippetListItem(s)).ToList()
            };
        }

        internal CategoryDetail CreateCategoryDetail(CodeCategoryEntity entity)
        {
            var snippetService = new SnippetService(_context);

            return new CategoryDetail
            {
                Id = entity.Id,
                CategoryName = entity.CategoryName,
                Snippets = entity.Snippets.Select(s => snippetService.CreateSnippetListItem(s)).ToList()
            };
        }
    }
}