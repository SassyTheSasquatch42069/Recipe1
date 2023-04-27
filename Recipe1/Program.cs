class Recipe
{
    // Making the array
    private string[] ingredients;
    private double[] quantity;
    private string[] measurement;
    private string[] steps;

    public Recipe()
    {
        // Making the arrays empty so that there is space to add info in ingredients, quanitity, measurement and steps.
        ingredients = new string[0];
        quantity = new double[0];
        measurement = new string[0];
        steps = new string[0];
    }
    public void ShowRecipe()
    {
        // Display the ingredients and measurements
        Console.WriteLine("Ingredients:");
        for (int w = 0; w < ingredients.Length; w++)
        {
            Console.WriteLine($"- {quantity[w]} {measurement[w]} of {ingredients[w]}");
        }

        // Display the steps
        Console.WriteLine("Steps:");
        for (int t = 0; t < steps.Length; t++)
        {
            Console.WriteLine($"- {steps[t]}");
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



    }



}