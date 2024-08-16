namespace recipe;


public class Recipe {
    public string Name {get; set;} = ""; //name of the recipe
    public string Ingredients {get; set;} = ""; //list of ingredients
    public string Instructions {get; set;} = ""; //cooking instructions
    public int CookingTime {get; set;} //cooking time in minutes
    public string Category {get; set;} = ""; //category of the recipe
}

// Recipe.cs: Represents the data structure for a single recipe.

