PROG Recipe App:

This app allows a user to create, save, view and delete recipes.
When the User wants to create a new recipe, the app will prompt the user with a message asking for the recipe name, ingredients, quantity, unit of measurement and the number of steps. All the inputs that the user gives for each of these will be saved in arrays.
Once the User has entered a recipe, they can then make the app display their recipe. This is done by taking the arrays that has the recipe info stored and displaying in through a for loop.
The User can also factor the recipe based on the serving they want to choose. This is done by taking the factor chosen and multiplying it with the qunatities of the recipe.
The user also has the options to reset the qunatities back into their original quantities.
Another option available to the user is to clear the recipes they have stored. This is done by making the arrays empty and making it have a value of 0.
The last Function is to exit the application.

App Required: C# Microsoft Visual Studios version 5

Installation: Clone the repository to the pc and run pip install -r requirements.txt and then run the app

How to use the app: The app will display many options to choose from and to choose which one you want to do you can just entering the corresponding number into the console. Number 1 to make a new recipe, 2 to show recipes made, 3 to scale the recipe, 4 to reset quantities, 5 to remove recipes and 6 to exit the app.
                    
(This App is made with C# adn no other coding language will be compatible with this app)

App Functionality:

The recipe app is made so that users have 6 different options to choose from.
The first option being making a new recipe which

https://github.com/SassyTheSasquatch42069/Recipe1#readme

Prog Part 2 essay:
The updates I have made to the current code is that I have created exception handling For each of the inputs that the user can give. The second update is that I have changed the display of the ingredients so that the colour text of the ingredients is different and the layout is easier to read.The third update is that the clear function now outputs a message to the user to confirm if they want the data cleared. The class structure has also been updated so that it is more logical.

Part 2 update:
The given code is a console application written in C#. It allows the user to manage recipes by entering recipe details, displaying recipe details, scaling recipe quantities, resetting recipe quantities, and clearing recipes. Here's a breakdown of the code:

The CaloriesCalculator class defines a static method CalculateTotalCalories that calculates the total calories by summing up the values in a list of integers.

The Recipe class represents a recipe and contains properties such as Name, Ingredients, Quantity, Measurement, Calories, Steps, and FoodGroup. It also has a constructor and a method EnterInfo to gather recipe information from the user.

The Measure class provides a method Measurements that takes a Recipe object and a scaling factor as input. It multiplies all the quantities in the recipe by the scaling factor.

The Reset class provides a method ResetQuantities that takes a Recipe object as input and divides all the quantities in the recipe by 2, effectively resetting them to half of their original values.

The Clear class provides a method ClearRecipe that takes a Recipe object as input and sets all the properties of the recipe to empty or cleared states.

The Show class is responsible for displaying recipe information to the user. It has a constructor that takes a list of recipes as input. It provides methods ShowRecipeNames and ShowRecipeDetails to display the names of all recipes and the details of a specific recipe, respectively. The ShowRecipeDetails method also calculates the total calories of the recipe and displays a message based on the calorie level.

The Program class contains the Main method, which serves as the entry point for the application. It creates instances of Show, Measure, Reset, and Clear classes. It then enters a while loop that displays a menu to the user and performs actions based on the user's choice. The available actions include entering recipe details, displaying recipe details, scaling recipe quantities, resetting recipe quantities, clearing recipes, and exiting the program.

Overall, the code provides a basic recipe management system where users can add, view, scale, reset, and clear recipes.

Final Part update:
In the final update, the main features and functionailty changes was the following:
Instead of using basic cs code to run the app, the app now runs on a xaml gui that is much better at displaying everything the user needs to see in order to use the app.

This is the explanation to the new code of the update:
MainWindow:

Two labels were added next to the buttons.
The label next to the "Create Recipe" button reads "Click here to create a new recipe".
The label next to the "Display Recipes" button reads "Click Display to show your saved recipes".
The buttons were repositioned closer to the right side of the window.
MainWindow Heading:

A label was added at the top center of the window.
The label displays the text "Welcome to Recipe App".
The text is in bold and larger than average size.
Background Color:

The background color of the MainWindow was changed to a peach color.
DisplayRecipesWindow:

The step number and checkbox were added to the Steps section.
Each step is displayed with its corresponding step number and a checkbox.
Exception Handling:

Exception handling was added to the RecipeWindow.
The recipe name input is validated to ensure it only contains string values.
If the recipe name is empty or contains non-letter characters, an appropriate error message is displayed.
Error messages are displayed using MessageBox.
These modifications enhance the user interface of the Recipe app, providing clear instructions, improved layout, and error handling for the recipe name input.

The user could enter recipes and its details such as ingredients, steps, calories and foodgroups. The app still has the calories warining message once a recipe that is entered has 300 calories or more. This then gets saved and can be displayed wehn the user clicks the display recipe button. This takes the user to a page with the recipes in a combobox in alphabetical order, once the user clicks a recipe, they are provided with the info related to the recipe. It also has a total calories at the bottom of the window. Then the user can click close on the display window and return to the menu and exit.
