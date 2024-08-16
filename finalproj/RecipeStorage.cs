using recipe;

public class RecipeStorage
{
    private List<Recipe> _recipes = new List<Recipe>();

    public List<Recipe> GetAllRecipes() => _recipes;

    public void AddRecipe(Recipe recipe)
    {
        _recipes.Add(recipe);
    }

    public void RemoveRecipe(Recipe recipe)
    {
        _recipes.Remove(recipe);
    }

    public void UpdateRecipe(int index, Recipe newRecipe)
    {
        if (index >= 0 && index < _recipes.Count)
        {
            _recipes[index] = newRecipe;
        }
    }
}
