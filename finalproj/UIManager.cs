namespace UI;
using recipeman;
using recipe;
using System;

// UIManager.cs: Manages user interaction, displaying menus, and processing user input.
public class UIManager
{
    private RecipeManager _manager;

    public UIManager(RecipeManager manager)
    {
        _manager = manager;
    }

    public void DisplayMainMenu()
    {
        string input;
        do
        {
            Console.Clear();
            Console.WriteLine("Recipe Management System");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Delete Recipe");
            Console.WriteLine("3. Edit Recipe");
            Console.WriteLine("4. View All Recipes");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            input = Console.ReadLine();
            HandleMenuSelection(input);
        } while (input != "5");
    }

    private void HandleMenuSelection(string input)
    {
        switch (input)
        {
            case "1":
                AddRecipe();
                break;
            case "2":
                DeleteRecipe();
                break;
            case "3":
                EditRecipe();
                break;
            case "4":
                ViewAllRecipes();
                break;
            case "5":
                break; // Exit the loop and close the application.
            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }
    }

    private void AddRecipe()
    {
        Console.WriteLine("Enter Recipe Name:");
        var name = Console.ReadLine();

        Console.WriteLine("Enter Ingredients (comma-separated):");
        var ingredients = Console.ReadLine();

        Console.WriteLine("Enter Instructions:");
        var instructions = Console.ReadLine();

        Console.WriteLine("Enter Cooking Time (minutes):");
        int cookingTime = int.Parse(Console.ReadLine()); // Assume input is valid integer.

        Console.WriteLine("Enter Category:");
        var category = Console.ReadLine();

        Recipe recipe = new Recipe
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

    private void DeleteRecipe()
    {
        Console.WriteLine("Enter the name of the recipe to delete:");
        var name = Console.ReadLine();
        _manager.DeleteRecipe(name);
        Console.WriteLine("Recipe deleted successfully!");
    }

    private void EditRecipe()
    {
        // Simplified for demonstration. Assume only editing name for simplicity.
        Console.WriteLine("Enter the name of the recipe to edit:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter new name:");
        var newName = Console.ReadLine();
        
        var recipe = _manager.GetRecipes().FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (recipe != null)
        {
            recipe.Name = newName; // Simple edit operation: updating the name.
            _manager.AddRecipe(recipe); // Re-add to update, in a real scenario you'd have a more complex update mechanism.
            Console.WriteLine("Recipe updated successfully!");
        }
        else
        {
            Console.WriteLine("Recipe not found!");
        }
    }

    private void ViewAllRecipes()
    {
        var recipes = _manager.GetRecipes();
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes to display.");
        }
        else
        {
            foreach (var recipe in recipes)
            {
                Console.WriteLine($"Name: {recipe.Name}, Ingredients: {recipe.Ingredients}, Instructions: {recipe.Instructions}, Time: {recipe.CookingTime} min, Category: {recipe.Category}");
            }
        }
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
