using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyConsoleApp;

namespace MyConsoleApp.Tests
{
    [TestClass]
    public class Activity3Tests
    {
        private Activity3 activity3;

        [TestInitialize]
        public void Setup()
        {
            activity3 = new Activity3();
        }

        [TestMethod]
        public void VoterEligibiltyChecker_Age18AndCitizenYes_ReturnsEligible()
        {
            // Act
            var result = activity3.VoterEligibiltyChecker(18, "yes");

            // Assert
            Assert.AreEqual("You are eligible to vote.", result);
        }

        [TestMethod]
        public void VoterEligibiltyChecker_Age17AndCitizenYes_ReturnsNotEligible()
        {
            // Act
            var result = activity3.VoterEligibiltyChecker(17, "yes");

            // Assert
            Assert.AreEqual("You are not eligible to vote.", result);
        }

        [TestMethod]
        public void VoterEligibiltyChecker_Age18AndCitizenNo_ReturnsNotEligible()
        {
            // Act
            var result = activity3.VoterEligibiltyChecker(18, "no");

            // Assert
            Assert.AreEqual("You are not eligible to vote.", result);
        }

        [TestMethod]
        public void VoterEligibiltyChecker_Age17AndCitizenNo_ReturnsNotEligible()
        {
            // Act
            var result = activity3.VoterEligibiltyChecker(17, "no");

            // Assert
            Assert.AreEqual("You are not eligible to vote.", result);
        }
    }
}