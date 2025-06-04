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
        public async Task<IActionResult> GetOnceAsync()
        {
            return Ok();
        }
        [HttpGet] //api/recipe?pageSize=10&pageNumber=1
        public async Task <IActionResult> GetListAsync([FromQuery]int pageSize,[FromQuery]int pageNumber)
        {
            // This is a placeholder for the actual implementation.
            // In a real application, you would retrieve recipes from a database or other data source.
            return Ok(pageSize+""+pageNumber);
        }
        [HttpPost]
        public IActionResult CreateRecipe([FromQuery]RecipeModel _recipemodel)
        {
            // This is a placeholder for the actual implementation.
            // In a real application, you would save the recipe to a database or other data source.
            //return CreatedAtAction(nameof(GetRecipes), new { id = 1 }, recipe);
            var businessLogic = new RecipeDetailRepository(_ctx);
            businessLogic.AddRecipe(_recipemodel);

            return Ok();
        }
      
    }
}
