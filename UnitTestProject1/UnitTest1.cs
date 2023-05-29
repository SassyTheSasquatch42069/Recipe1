using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeApp;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class CaloriesCalculatorTests
    {
        [TestMethod]
        public void CalculateTotalCalories_ShouldReturnZero_WhenNoCaloriesProvided()
        {
            // Arrange
            List<int> calories = new List<int>();

            // Act
            int totalCalories = CaloriesCalculator.CalculateTotalCalories(calories);

            // Assert
            Assert.AreEqual(0, totalCalories);
        }

        [TestMethod]
        public void CalculateTotalCalories_ShouldReturnCorrectTotalCalories()
        {
            // Arrange
            List<int> calories = new List<int> { 100, 150, 200, 75 };

            // Act
            int totalCalories = CaloriesCalculator.CalculateTotalCalories(calories);

            // Assert
            Assert.AreEqual(525, totalCalories);
        }
    }
}
