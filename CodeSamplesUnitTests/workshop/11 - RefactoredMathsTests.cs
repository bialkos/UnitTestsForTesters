using System.Collections.Generic;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    public class RefactoredMathsTests
    {
        private Math math;

        [SetUp]
        public void Setup()
        {
            math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GetGreaterNumber_FirstArgumentGreater_ReturnsFirstArgument()
        {
            var result = math.GetGreaterNumber(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetGreaterNumber_SecondArgumentGreater_ReturnsSecondArgument()
        {
            var result = math.GetGreaterNumber(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetGreaterNumber_ArgumentsAreEqual_ReturnsTheSameArgument()
        {
            var result = math.GetGreaterNumber(2,2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetOddNumber_WhenLimitIsGraterThanZero_ReturnsOddNumbersWithinLimit()
        {
            var result = math.GetOddNumbers(7);
            Assert.That(result, Is.EquivalentTo(new int[] { 1, 3, 5, 7 })); 
        }
    }
}