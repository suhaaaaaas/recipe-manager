namespace recipeman;
using recipe;
using file;

// RecipeManager.cs: Manages a list of recipes and performs operations like add, delete, and update.
public class RecipeManager
{
    private List<Recipe> recipes = new List<Recipe>();
    private FileManager fileManager;

    public RecipeManager(string filePath)
    {
        fileManager = new FileManager(filePath);
        recipes = fileManager.LoadRecipes(); // Load recipes from the file on initialization.
    }

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
        fileManager.SaveRecipes(recipes); // Save changes immediately.
    }

    public void DeleteRecipe(string recipeName)
    {
        recipes.RemoveAll(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
        fileManager.SaveRecipes(recipes); // Save changes immediately.
    }

    public List<Recipe> GetRecipes()
    {
        return recipes;
    }
}
