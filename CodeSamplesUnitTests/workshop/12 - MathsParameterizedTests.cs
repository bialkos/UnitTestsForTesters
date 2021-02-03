using System.Collections.Generic;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    public class ParameterizedMathsTests
    {
        private Math math;

        [SetUp]
        public void Setup()
        {
            math = new Math();
        }

        [TestCase(2, 1, 2, TestName = "First argument greater, 1st arg returned.")]
        [TestCase(1, 2, 2, TestName = "Second argument greater, 2nd arg returned.")]
        [TestCase(2, 2, 2, TestName = "Arguments equal, any arg returned.")]
        public void GetGreaterNumber_GivenTwoArguments_ReturnsTheGreate2r(int a, 
                                                            int b, 
                                                            int expectedResult)
        {
            var result = math.GetGreaterNumber(a, b);
            Assert.That(result, Is.EqualTo(expectedResult)); 
        }

        [TestCase(5, new int[] {1,3,5})]
        [TestCase(7, new int[] {1,3,5,7})]
        public void GetOddNumber_WhenLimitIsGraterThanZero_ReturnsOddNumbersWithinLimit(int limitInput, IEnumerable<int> expectedResult)
        {
            var result = math.GetOddNumbers(limitInput);
            Assert.That(result, Is.EquivalentTo(expectedResult)); // EquivalentTo() checks content, not the order of the collection.
        }

        [Test]
        [Ignore("Ignored for the sake of practice")]
        public void FailingTest()
        {
            Assert.Fail("This test always fails! :(");
        }
    }
}