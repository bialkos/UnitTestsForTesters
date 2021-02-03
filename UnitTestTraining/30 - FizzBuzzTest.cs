using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace UnitTestTraining
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Category("FizzBuzzPositive")]
        [TestCase(3)]
        [TestCase(63)]
        [TestCase(-21)]
        public void GetOutput_ReturnFizz(int value)
        {
            //Act
            var result = FizzBuzz.GetOutput(value);
            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Category("FizzBuzzPositive")]
        [TestCase(5)]
        [TestCase(-20)]
        [TestCase(55)]
        public void GetOutput_ReturnBuzz(int value)
        {
            //Act
            var result = FizzBuzz.GetOutput(value);
            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Category("FizzBuzzPositive")]
        [TestCase(0)]
        [TestCase(60)]
        [TestCase(-150)]
        public void GetOutput_ReturnFizzBuzz(int value)
        {
            //Act
            var result = FizzBuzz.GetOutput(value);
            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Category("FizzBuzzNegative")]
        [TestCase(-4)]
        [TestCase(112)]
        [TestCase(176)]
        public void GetOutput_ReturnNumber(int value)
        {
            //Act
            var result = FizzBuzz.GetOutput(value);
            //Assert
            Assert.That(result, Is.EqualTo(value.ToString()));
        }
    }
}
