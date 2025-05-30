using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DbHandler.Model;

namespace Recipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecipes()
        {
            // This is a placeholder for the actual implementation.
            // In a real application, you would retrieve recipes from a database or other data source.
            return Ok(new[] { "Recipe1", "Recipe2", "Recipe3" });
        }
        [HttpPost]
        public IActionResult CreateRecipe(RecipeModel _recipemodel)
        {
            // This is a placeholder for the actual implementation.
            // In a real application, you would save the recipe to a database or other data source.
            //return CreatedAtAction(nameof(GetRecipes), new { id = 1 }, recipe);
            return Ok();
        }
      
    }
}
