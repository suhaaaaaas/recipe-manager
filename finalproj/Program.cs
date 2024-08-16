using recipeman;
using UI;
using file;

// Program.cs: Main class that starts the application.
class Program
{
    static void Main(string[] args)
    {
        string filePath = "recipes.txt"; // Path to the recipe file.
        RecipeManager manager = new RecipeManager(filePath);
        UIManager uiManager = new UIManager(manager);
        uiManager.DisplayMainMenu(); // Start displaying the main user interface menu.
    }
}

