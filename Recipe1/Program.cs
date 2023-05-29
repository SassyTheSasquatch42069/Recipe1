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
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
public void Measurements(double factor)
    {
        // Multiply all the quantities by utilizing the scaling factor
        for (int v = 0; v < quantity.Length; v++)
        {
            quantity[v] *= factor;
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



    






