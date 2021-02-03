using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    [TestFixture]
    public class SimpleMathsTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Arrange
            Math math = new Math();
            //Act
            var result = math.Add(1, 2);
            //Assert
            Assert.AreEqual(result,3);
        }

        [Test]
        public void GetGreaterNumber_FirstArgumentGreater_ReturnsFirstArgument()
        {
            //Arrange
            Math math = new Math();
            //Act
            var result = math.GetGreaterNumber(2, 1);
            //Assert
            Assert.AreEqual(result, 2);
        }
        [Test]
        public void GetGreaterNumber_SecondArgumentGreater_ReturnsSecondArgument()
        {
            //Arrange
            Math math = new Math();
            //Act
            var result = math.GetGreaterNumber(1, 2);
            //Assert
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void GetGreaterNumber_ArgumentsAreEqual_ReturnsTheSameArgument()
        {
            //Arrange
            Math math = new Math();
            //Act
            var result = math.GetGreaterNumber(2,2);
            //Assert
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void GetOddNumber_WhenLimitIsGraterThanZero_ReturnsOddNumbersWithinLimit()
        {
            //Arrange
            Math math = new Math();
            //Act
            var result = math.GetOddNumbers(7);
            //Assert
            Assert.That(result, Is.EquivalentTo(new int[] { 1, 3, 5, 7 })); // EquivalentTo() checks content, not the order of the collection.
        }
    }
}



