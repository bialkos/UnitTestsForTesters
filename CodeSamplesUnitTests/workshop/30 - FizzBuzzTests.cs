using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(15)]
        [TestCase(45)]
        [TestCase(60)]
        public void GetOutput_WhenDivisibleByThreeAndFive_ReturnsFizzBuzz(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo("fizzbuzz").IgnoreCase);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GetOutput_WhenDivisibleByThree_ReturnsFizz(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo("fizz").IgnoreCase);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(40)]
        public void GetOutput_WhenDivisibleByFive_ReturnsBuzz(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo("buzz").IgnoreCase);
        }

        [TestCase(7)]
        [TestCase(11)]
        [TestCase(17)]
        public void GetOutput_WhenNotDivisibleByThreeOrFive_ReturnsTheSameNumber(int input)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo(input.ToString()));
        }
    }
}