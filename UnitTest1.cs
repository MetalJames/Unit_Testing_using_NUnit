using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        //Valid input and valid messages
        // Test_01
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage_01()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        //Invalid input and invalid messages
        // Test 02
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_01()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 30;
            int thirdAngle = 79;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        // Test 03
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_02()
        {
            // Arrange
            int firstAngle = 70;
            int secondAngle = 41;
            int thirdAngle = 70;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        // Test 04
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_03()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 90;
            int thirdAngle = 90;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            //Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        // Test 05
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_04()
        {
            // Arrange
            int firstAngle = 50;
            int secondAngle = '*';
            int thirdAngle = 'a';
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        // Test 06
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_05()
        {
            // Arrange
            int firstAngle = -30;
            int secondAngle = -60;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        // Test 07
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_06()
        {
            // Arrange
            string firstAngle = "90";
            string secondAngle = "60";
            string thirdAngle = " ";
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        // Test 08
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_07()
        {
            // Arrange
            int firstAngle = 60;
            string secondAngle = "60";
            string thirdAngle = "";
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        // Test 09
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage_08()
        {
            // Arrange
            object firstAngle = null;
            int secondAngle = 60;
            string thirdAngle = "60";
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
    }
}