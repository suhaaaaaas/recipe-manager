namespace input;

public class InputValidator
{
    public bool ValidateRecipeName(string name)
    {
        // Simple validation: check if the name is not empty
        return !string.IsNullOrWhiteSpace(name);
    }

    public bool ValidateCookingTime(string input, out int cookingTime)
    {
        // Validate that the input can be converted to an integer
        return int.TryParse(input, out cookingTime) && cookingTime > 0;
    }
}

// InputValidator.cs: Validates user input to ensure it meets expected formats and conditions.

