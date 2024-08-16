# Recipe Management System

## Project Overview
The Recipe Management System is a console-based application designed to help users manage their recipes effectively. Users can add, delete, edit, and view recipes. The system is structured into several classes, each responsible for specific functionalities such as recipe management, user interaction, data persistence, input validation, command execution, data storage, and logging.

---

### Class and Method Descriptions

#### `Program`
- **`Main()`**: Initializes the main components and starts the application.

  **Description**: Serves as the entry point of the application, setting up necessary components and initiating the user interface.

---

#### `Recipe`
- **Description**: Defines the properties of a recipe.

  **Properties**:
  - `Name`: The name of the recipe.
  - `Ingredients`: A list detailing the ingredients required.
  - `Instructions`: Step-by-step guidelines to prepare the recipe.
  - `CookingTime`: The time required to cook the recipe.
  - `Category`: The classification of the recipe (e.g., Dessert, Main Course).

---

#### `RecipeManager`
- **Methods**:
  - `AddRecipe(Recipe recipe)`: Adds a new recipe to the collection and saves it to the file.
  - `DeleteRecipe(string recipeName)`: Removes a recipe by its name from the collection and updates the file.
  - `GetRecipes()`: Retrieves the list of all recipes.

  **Description**: Manages operations related to recipes, ensuring that any addition or deletion is reflected both in the in-memory collection and the persistent storage.

---

#### `FileManager`
- **Methods**:
  - `SaveRecipes(List<Recipe> recipes)`: Saves the current list of recipes to a file.
  - `LoadRecipes()`: Loads recipes from a file into the system.

  **Description**: Handles all file operations, ensuring that recipes are persistently stored and retrieved as needed.

---

#### `UIManager`
- **Methods**:
  - `DisplayMainMenu()`: Shows the main menu and manages user interactions.
  - `HandleMenuSelection(string input)`: Processes the user's menu choice and triggers the corresponding action.
  - `AddRecipe()`: Manages the user interface for adding a new recipe.
  - `DeleteRecipe()`: Manages the user interface for deleting an existing recipe.
  - `EditRecipe()`: Manages the user interface for editing an existing recipe.
  - `ViewAllRecipes()`: Displays all recipes from the `RecipeManager`.

  **Description**: Oversees all user interactions, providing interfaces for various operations and ensuring a smooth user experience.

---

#### `InputValidator` *(Assumed from functionality needs)*
- **Methods**:
  - `ValidateStringNotEmpty(string input)`: Checks if a string is neither empty nor null.
  - `ValidatePositiveInteger(string input, out int result)`: Ensures that a string can be parsed into a positive integer.

  **Description**: Offers validation services for user inputs, ensuring data integrity and correctness.

---

#### `CommandExecutor` *(Assumed from functionality needs)*
- **Methods**:
  - `ExecuteAddRecipeCommand()`: Facilitates the process of adding a recipe.
  - `ExecuteDeleteRecipeCommand()`: Facilitates the process of deleting a recipe.
  - `ExecuteViewRecipesCommand()`: Facilitates the process of viewing all recipes.

  **Description**: Executes user commands related to recipe management, coordinating tasks among different components.

---

#### `RecipeStorage` *(Hypothetical for enhanced data management)*
- **Methods**:
  - `AddRecipe(Recipe recipe)`: Adds a recipe to the internal storage.
  - `RemoveRecipe(Recipe recipe)`: Removes a recipe from the internal storage.
  - `GetAllRecipes()`: Retrieves all stored recipes.

  **Description**: Manages in-memory storage of recipes, providing centralized access and manipulation of recipe data.

---

#### `Logger` *(Hypothetical for logging and debugging)*
- **Methods**:
  - `Log(string message)`: Records a message to the console or a log file.

  **Description**: Provides logging functionalities to track operations, errors, warnings, and informational messages, aiding in debugging and monitoring.

---
