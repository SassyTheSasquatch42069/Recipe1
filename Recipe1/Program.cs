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
}