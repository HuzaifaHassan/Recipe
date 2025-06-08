using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DbHandler.Model;
using DbHandler.Repositories;
using DbHandler.Data;

namespace Recipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly ApplicationDbContext _ctx;
        private readonly IRecipeDetailRepository _recipeDetailRepository;
        public RecipeController(ApplicationDbContext ctx, IRecipeDetailRepository recipeDetailRepository)
        {
            _ctx = ctx;
            _recipeDetailRepository = recipeDetailRepository;
        }

        [HttpGet("{recipeId:guid}")]
        public async Task<IActionResult> GetOnceAsync([FromRoute] Guid recipeId)
        {
            return Ok(recipeId);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetListAsync([FromQuery] int pageSize, [FromQuery] int pageNumber)
        {
            return Ok($"{pageSize} {pageNumber}");
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeModel _recipemodel)
        {
            // This is a placeholder for the actual implementation.
            // In a real application, you would save the recipe to a database or other data source.
            //return CreatedAtAction(nameof(GetRecipes), new { id = 1 }, recipe);
            var businessLogic = new RecipeDetailRepository(_ctx);
            businessLogic.AddRecipe(_recipemodel);

            return Ok(businessLogic);
        }
        public async Task<IActionResult> PutAsync([FromBody] RecipeModel _recipemodel)
        {
            return Ok(_recipemodel);
        }
        [HttpDelete("{recipeid}")]
        public async Task<IActionResult> DeleteAsync(Guid recipeId)
        {
            // This is a placeholder for the actual implementation.
            // In a real application, you would delete the recipe from a database or other data source.
            return Ok(recipeId);
        }
    }
}
