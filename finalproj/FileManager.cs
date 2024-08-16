namespace file;
using recipe;

using System.Collections.Generic;
using System.IO;
using System.Linq;

// FileManager.cs: Manages reading from and writing to a file, handling recipe data persistence.
public class FileManager
{
    private string _filePath;

    public FileManager(string filePath)
    {
        _filePath = filePath;
    }

    public void SaveRecipes(List<Recipe> recipes)
    {
        var lines = recipes.Select(r => $"{r.Name}|{r.Ingredients}|{r.Instructions}|{r.CookingTime}|{r.Category}");
        File.WriteAllLines(_filePath, lines);
    }

    public List<Recipe> LoadRecipes()
    {
        var recipes = new List<Recipe>();
        if (!File.Exists(_filePath))
        {
            return recipes; // If the file does not exist, return an empty list.
        }

        var lines = File.ReadAllLines(_filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            recipes.Add(new Recipe {
                Name = parts[0],
                Ingredients = parts[1],
                Instructions = parts[2],
                CookingTime = int.Parse(parts[3]),
                Category = parts[4]
            });
        }
        return recipes;
    }
}
