using System;
using System.Collections.Generic;

class CaloriesCalculator
{//Code to calculate the total calories from the list calories
    public static int CalculateTotalCalories(List<int> calories)
    {
        int totalCalories = 0;
        foreach (int cal in calories)
        {
            totalCalories += cal;
        }
        return totalCalories;
    }
}

class Recipe
{
    // Making the list with get and set
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public List<double> Quantity { get; set; }
    public List<string> Measurement { get; set; }
    public List<int> Calories { get; set; }
    public List<string> Steps { get; set; }
    public List<string> FoodGroup { get; set; }

    public Recipe()
    {//Giving the list what input types it can store
        Ingredients = new List<string>();
        Quantity = new List<double>();
        Measurement = new List<string>();
        Calories = new List<int>();
        Steps = new List<string>();
        FoodGroup = new List<string>();
    }
    public void EnterInfo()
    {//try and catch so code doesnt crash if an input is invalid
        try
        {//asks the user to enter the recipe name
            Console.WriteLine("Enter Recipe Name: ");
            Name = Console.ReadLine();

            //allows user to enter the ingredients of the recipe
            Console.Write("Enter the number of ingredients: ");
            int nIngredients = int.Parse(Console.ReadLine());

            //for loop so that it can capture all the ingredients involved and to capture calories,quantity,measurement and food group
            for (int p = 0; p < nIngredients; p++)
            {
                Console.WriteLine($"Enter the details for ingredient #{p + 1}:");
                Console.Write("Name: ");
                string ingredient = Console.ReadLine();
                Ingredients.Add(ingredient);

                Console.WriteLine("Enter the number of calories this ingredient has: ");
                int cal = int.Parse(Console.ReadLine());
                Calories.Add(cal);

                Console.Write("Quantity: ");
                double quant = double.Parse(Console.ReadLine());
                Quantity.Add(quant);

                Console.Write("Unit of measurement: ");
                string measure = Console.ReadLine();
                Measurement.Add(measure);

                Console.WriteLine("Select the food group for this ingredient:");
                Console.WriteLine("1 - Starchy Foods");
                Console.WriteLine("2 - Vegetables and fruits");
                Console.WriteLine("3 - Dry beans, peas, lentils, and soya");
                Console.WriteLine("4 - Chicken, Fish, meat, and eggs");
                Console.WriteLine("5 - Milk and dairy products");
                Console.WriteLine("6 - Fats and oil");
                Console.WriteLine("7 - Water");

                string foodGroupChoice = Console.ReadLine();
                //switch case for food group choice so that the user can only enter what is given
                switch (foodGroupChoice)
                {
                    case "1":
                        FoodGroup.Add("Starchy Foods");
                        break;
                    case "2":
                        FoodGroup.Add("Vegetables and fruits");
                        break;
                    case "3":
                        FoodGroup.Add("Dry beans, peas, lentils, and soya");
                        break;
                    case "4":
                        FoodGroup.Add("Chicken, Fish, meat, and eggs");
                        break;
                    case "5":
                        FoodGroup.Add("Milk and dairy products");
                        break;
                    case "6":
                        FoodGroup.Add("Fats and oil");
                        break;
                    case "7":
                        FoodGroup.Add("Water");
                        break;
                    default:
                        Console.WriteLine("Invalid food group choice. Food group set as Other.");
                        FoodGroup.Add("Other");
                        break;
                }
            }
            //steps involved in the recipe is added here
            Console.Write("Enter the number of steps: ");
            int nSteps;
            while (!int.TryParse(Console.ReadLine(), out nSteps))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number of steps:");
                Console.ResetColor();
            }

            for (int j = 0; j < nSteps; j++)
            {
                Console.Write($"Enter step #{j + 1}: ");
                string step = Console.ReadLine();
                Steps.Add(step);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
class Measure
{//used to change the recipe measurements based on the servings
    public void Measurements(Recipe recipe, double factor)
    {
        List<double> quantity = recipe.Quantity;
        // Multiply all the quantities by the scaling factor
        for (int v = 0; v < quantity.Count; v++)
        {
            quantity[v] *= factor;
        }
    }
}

class Reset
{
    public void ResetQuantities(Recipe recipe)
    {
        List<double> quantity = recipe.Quantity;
        // Reset all the quantities back into their original values
        for (int h = 0; h < quantity.Count; h++)
        {
            quantity[h] /= 2;
        }
    }
}

class Clear
{
    public void ClearRecipe(Recipe recipe)
    {
        // Reset all the recipe properties to make them empty
        recipe.Name = "";
        recipe.Ingredients.Clear();
        recipe.Quantity.Clear();
        recipe.Measurement.Clear();
        recipe.Calories.Clear();
        recipe.Steps.Clear();
        recipe.FoodGroup.Clear();
    }
}

class Show
{//calling the lists and alert into the class
    private List<Recipe> recipes;
    private AlertUserDelegate alertAction;

    public Show(List<Recipe> recipes)
    {
        this.recipes = recipes;
        alertAction = AlertUser;
    }


    public void ShowRecipeNames()
    {//displays the recipe name in alphabetical order
        Console.WriteLine("Recipe Names:");
        List<string> sortedNames = new List<string>();
        foreach (Recipe recipe in recipes)
        {
            sortedNames.Add(recipe.Name);
        }
        sortedNames.Sort(); // Sort the recipe names alphabetically
        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }

    public void ShowRecipeDetails(string recipeName)
    {
        try
        {//searches for the recipe that the user inputs
            Recipe selectedRecipe = recipes.Find(recipe => recipe.Name == recipeName);
            if (selectedRecipe != null)
            {//displays the info of the selected recipe
                Console.WriteLine("Recipe Details:");
                Console.WriteLine("Ingredients:");
                for (int i = 0; i < selectedRecipe.Ingredients.Count; i++)
                {
                    Console.WriteLine($"{selectedRecipe.Ingredients[i]} - {selectedRecipe.Quantity[i]} {selectedRecipe.Measurement[i]} ({selectedRecipe.FoodGroup[i]})");
                }

                int totalCalories = CaloriesCalculator.CalculateTotalCalories(selectedRecipe.Calories);

                Console.WriteLine($"Total Calories: {totalCalories} ");
                //lets the user know the calorie rating in different colors based on the size of the value
                if (totalCalories < 150)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("This recipe is low in calories.");
                    Console.ResetColor();
                }
                else if (totalCalories >= 150 && totalCalories < 300)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This recipe is average in calories.");
                    Console.ResetColor();
                }
                else
                {//alerts the user that the recipe is over 300 calories
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This recipe is high in calories.");
                    alertAction?.Invoke("This recipe has more than 300 calories!");
                    Console.ResetColor();
                }
                //displays steps
                Console.WriteLine("Steps:");
                for (int i = 0; i < selectedRecipe.Steps.Count; i++)
                {
                    Console.WriteLine($"Step #{i + 1}: {selectedRecipe.Steps[i]}");
                }
            }
            else
            {//message if invalid recipe is entered
                Console.WriteLine("Recipe not found!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
    static void AlertUser(string message)
    {//the message that will pop up if the user has more than 300 calories in a recipe
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ALERT: " + message);
        Console.ResetColor();
    }
    delegate void AlertUserDelegate(string message);
}

class Program
{// gui code for the user to interact with
    static void Main(string[] args)
    {//calling the lists 
        List<Recipe> recipes = new List<Recipe>();
        Show show = new Show(recipes);
        Measure measure = new Measure();
        Reset reset = new Reset();
        Clear clear = new Clear();

        while (true)
        {//while loop so that the app can run and return back to this start
            Console.WriteLine("Enter '1' to enter recipe details");
            Console.WriteLine("Enter '2' to display recipe details");
            Console.WriteLine("Enter '3' to scale recipe");
            Console.WriteLine("Enter '4' to reset recipe quantities");
            Console.WriteLine("Enter '5' to clear recipe");
            Console.WriteLine("Enter '6' to exit");

            string choice = Console.ReadLine();
            switch (choice)
            {//switch case so that the user can enter an unlimited amount of recipes
                case "1":
                    Recipe recipe = new Recipe();
                    recipe.EnterInfo();
                    recipes.Add(recipe);
                    break;
                case "2":
                    show.ShowRecipeNames();
                    Console.WriteLine("Enter the recipe name:");
                    string recipeName = Console.ReadLine();
                    show.ShowRecipeDetails(recipeName);
                    break;

                case "3":
                    show.ShowRecipeNames();
                    Console.WriteLine("Enter the recipe name to scale:");
                    string recipeNameToScale = Console.ReadLine();
                    Recipe recipeToScale = recipes.Find(recipe => recipe.Name == recipeNameToScale);
                    if (recipeToScale != null)
                    {
                        Console.WriteLine("Enter the scaling factor:");
                        double scalingFactor;
                        while (!double.TryParse(Console.ReadLine(), out scalingFactor))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Please enter a valid scaling factor:");
                            Console.ResetColor();
                        }
                        measure.Measurements(recipeToScale, scalingFactor);
                        Console.WriteLine("Recipe scaled successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Recipe not found!");
                    }
                    break;
                case "4":
                    show.ShowRecipeNames();
                    Console.WriteLine("Enter the recipe name to reset quantities:");
                    string recipeNameToReset = Console.ReadLine();
                    Recipe recipeToReset = recipes.Find(recipe => recipe.Name == recipeNameToReset);
                    if (recipeToReset != null)
                    {
                        reset.ResetQuantities(recipeToReset);
                        Console.WriteLine("Recipe quantities reset successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Recipe not found!");
                    }
                    break;
                case "5":
                    show.ShowRecipeNames();
                    Console.WriteLine("Enter the recipe name to clear:");
                    string recipeNameToClear = Console.ReadLine();
                    Recipe recipeToClear = recipes.Find(recipe => recipe.Name == recipeNameToClear);
                    if (recipeToClear != null)
                    {
                        clear.ClearRecipe(recipeToClear);
                        Console.WriteLine("Recipe cleared successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Recipe not found!");
                    }
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid choice.");
                    break;
            }
        }
    }
}













