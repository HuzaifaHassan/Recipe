using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DbHandler.Model;
using DbHandler.Data;

namespace DbHandler.Repositories
{
    public class RecipeDetailRepository:IRecipeDetailRepository
    {
        private readonly ApplicationDbContext _context;
        public RecipeDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        


        // Implement methods for recipe details here, e.g., GetRecipeById, AddRecipe, UpdateRecipe, DeleteRecipe, etc.
        public RecipeModel GetRecipeById(int id)
        {
            return _context.Recipes.Find(id);
        }
        public IEnumerable<RecipeModel> GetAllRecipes()
        {
            return _context.Recipes.ToList();
        }
        public void AddRecipe(RecipeModel recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }
    }
    
}
