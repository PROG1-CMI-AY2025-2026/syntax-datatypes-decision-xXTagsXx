using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyConsoleApp;

namespace MyConsoleApp.Tests
{
    [TestClass]
    public class Activity2Tests
    {
        [TestMethod]
        public void UmbrellaChecker_Rainy_ReturnsBringUmbrella()
        {
            // Arrange
            var activity2 = new Activity2();

            // Act
            var result = activity2.UmbrellaChecker("rainy");

            // Assert
            Assert.AreEqual("Bring an umbrella!", result);
        }

        [TestMethod]
        public void UmbrellaChecker_Sunny_ReturnsNoUmbrellaNeeded()
        {
            // Arrange
            var activity2 = new Activity2();

            // Act
            var result = activity2.UmbrellaChecker("sunny");

            // Assert
            Assert.AreEqual("No umbrella needed.", result);
        }

        [TestMethod]
        public void UmbrellaChecker_Invalid_ReturnsInvalidWeatherCondition()
        {
            // Arrange
            var activity2 = new Activity2();

            // Act
            var result = activity2.UmbrellaChecker("cloudy");

            // Assert
            Assert.AreEqual("Invalid weather condition.", result);
        }
    }
}