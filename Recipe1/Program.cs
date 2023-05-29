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
public void EnterInfo()
    {
        // Asks the user to enter the amount of ingredients required for the recipe
        Console.Write("Enter the number of ingredients: ");
        int nIngredients = int.Parse(Console.ReadLine());


        // Making the arrays fit with the correct size
        ingredients = new string[nIngredients];
        quantity = new double[nIngredients];
        measurement = new string[nIngredients];

        // Asks the user to enter the details of each ingredient
        for (int p = 0; p < nIngredients; p++)
        {
            Console.WriteLine($"Enter the details for ingredient #{p + 1}:");
            Console.Write("Name: ");
            ingredients[p] = Console.ReadLine();
            Console.Write("Quantity: ");
            quantity[p] = double.Parse(Console.ReadLine());
            Console.Write("Unit of measurement: ");
            measurement[p] = Console.ReadLine();
        }

        // Asks the user to identify the amount of steps in the recipe
        Console.Write("Enter the number of steps: ");
        int nSteps = int.Parse(Console.ReadLine());

        // Making the steps array fit with the correct size
        steps = new string[nSteps];

        // Ask the user to enter the details for each step of the recipe
        for (int j = 0; j < nSteps; j++)
        {
            Console.Write($"Enter step #{j + 1}: ");
            steps[j] = Console.ReadLine();
        }
    }

    public void Reset()
    {
        // Reset all the quantities back into their original values
        for (int h = 0; h < quantity.Length; h++)
        {
            quantity[h] /= 2;
        }
    }

    public void Clear()
    {
        // Reset all the arrays to make them empty
        ingredients = new string[0];
        quantity = new double[0];
        measurement = new string[0];
        steps = new string[0];
    }

}

class Menu
{
    static void Main(string[] args)
    {
        //Changes Font colour in console menu
        Console.ForegroundColor = ConsoleColor.Red;

        // bringing in the class to utilize its methods
        Recipe recipe = new Recipe();
        while (true)
        {
            // Display the options for the user to pick
            Console.WriteLine("Enter '1' to enter recipe details");
            Console.WriteLine("Enter '2' to display recipe");
            Console.WriteLine("Enter '3' to scale recipe");
            Console.WriteLine("Enter '4' to reset quantities");
            Console.WriteLine("Enter '5' to clear recipe");
            Console.WriteLine("Enter '6' to exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                // All code below is using the methods from Recipe to make the menu work
                case "1":
                    recipe.EnterInfo();
                    break;
                case "2":
                    recipe.ShowRecipe();
                    break;
                case "3":
                    Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                    double factor = double.Parse(Console.ReadLine());
                    recipe.Measurements(factor);
                    break;
                case "4":
                    recipe.Reset();
                    break;
                case "5":
                    recipe.Clear();
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



    






