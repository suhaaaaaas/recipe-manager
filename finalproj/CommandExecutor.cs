using recipe;
using recipeman;
using file;
using UI;
using System;
using System.Linq;

// CommandExecutor.cs: Executes specific actions related to recipe management.
public class CommandExecutor
{
    private RecipeManager _manager;

    // Constructor to set up the manager
    public CommandExecutor(RecipeManager manager)
    {
        _manager = manager;
    }

    // Adds a new recipe by gathering input from the user
    public void ExecuteAddRecipeCommand()
    {
        Console.WriteLine("Enter Recipe Name:");
        var name = Console.ReadLine();

        Console.WriteLine("Enter Ingredients (comma-separated):");
        var ingredients = Console.ReadLine();

        Console.WriteLine("Enter Instructions:");
        var instructions = Console.ReadLine();

        Console.WriteLine("Enter Cooking Time (minutes):");
        if (!int.TryParse(Console.ReadLine(), out int cookingTime) || cookingTime <= 0)
        {
            Console.WriteLine("Invalid cooking time. Please enter a positive integer.");
            return;
        }

        Console.WriteLine("Enter Category:");
        var category = Console.ReadLine();

        var recipe = new Recipe
        {
            Name = name,
            Ingredients = ingredients,
            Instructions = instructions,
            CookingTime = cookingTime,
            Category = category
        };

        _manager.AddRecipe(recipe);
        Console.WriteLine("Recipe added successfully!");
    }

    // Deletes a recipe specified by the user
    public void ExecuteDeleteRecipeCommand()
    {
        Console.WriteLine("Enter the name of the recipe to delete:");
        var name = Console.ReadLine();
        
        _manager.DeleteRecipe(name);
        Console.WriteLine("Recipe deleted successfully if it existed.");
    }

    // Displays all recipes managed by the RecipeManager
    public void ExecuteViewRecipesCommand()
    {
        var recipes = _manager.GetRecipes();
        if (!recipes.Any())
        {
            Console.WriteLine("No recipes to display.");
            return;
        }

        foreach (var recipe in recipes)
        {
            DisplayRecipe(recipe);
        }
    }

    // Allows editing of an existing recipe's details
    public void ExecuteEditRecipeCommand()
    {
        Console.WriteLine("Enter the name of the recipe to edit:");
        var name = Console.ReadLine();
        var recipe = _manager.GetRecipes().FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (recipe == null)
        {
            Console.WriteLine("Recipe not found.");
            return;
        }

        // Assuming update involves all fields for simplicity
        Console.WriteLine("Enter new Ingredients (comma-separated, press ENTER to skip):");
        var ingredients = Console.ReadLine();
        recipe.Ingredients = string.IsNullOrEmpty(ingredients) ? recipe.Ingredients : ingredients;

        Console.WriteLine("Enter new Instructions (press ENTER to skip):");
        var instructions = Console.ReadLine();
        recipe.Instructions = string.IsNullOrEmpty(instructions) ? recipe.Instructions : instructions;

        Console.WriteLine("Enter new Cooking Time (minutes, press ENTER to skip):");
        if (int.TryParse(Console.ReadLine(), out int cookingTime) && cookingTime > 0)
        {
            recipe.CookingTime = cookingTime;
        }

        Console.WriteLine("Enter new Category (press ENTER to skip):");
        var category = Console.ReadLine();
        recipe.Category = string.IsNullOrEmpty(category) ? recipe.Category : category;

        Console.WriteLine("Recipe updated successfully!");
    }

    // Displays a single recipe in a detailed format
    private void DisplayRecipe(Recipe recipe)
    {
        Console.WriteLine("\nRecipe Details:");
        Console.WriteLine($"Name: {recipe.Name}");
        Console.WriteLine($"Ingredients: {recipe.Ingredients}");
        Console.WriteLine($"Instructions: {recipe.Instructions}");
        Console.WriteLine($"Cooking Time: {recipe.CookingTime} minutes");
        Console.WriteLine($"Category: {recipe.Category}");
        Console.WriteLine("-------------------------------");
    }
}
