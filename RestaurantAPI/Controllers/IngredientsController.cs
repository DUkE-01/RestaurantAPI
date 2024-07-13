using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/ingredients")]
[Authorize(Roles = "Admin")]
public class IngredientsController : ControllerBase
{
    private readonly IIngredientService _ingredientService;

    public IngredientsController(IIngredientService ingredientService)
    {
        _ingredientService = ingredientService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateIngredient([FromBody] IngredientCreateViewModel model)
    {
        // Implementa la lógica para crear un nuevo ingrediente
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateIngredient(int id, [FromBody] IngredientUpdateViewModel model)
    {
        // Implementa la lógica para actualizar un ingrediente
    }

    [HttpGet]
    public async Task<IActionResult> GetAllIngredients()
    {
        // Implementa la lógica para obtener todos los ingredientes
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetIngredientById(int id)
    {
        // Implementa la lógica para obtener un ingrediente por su ID
    }
}
