using DbHandler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHandler.Repositories
{
    public interface IRecipeDetailRepository
    {
        public RecipeModel GetRecipeById(int id);
        public void AddRecipe(RecipeModel recipe);
        public IEnumerable<RecipeModel> GetAllRecipes();

    }
}
