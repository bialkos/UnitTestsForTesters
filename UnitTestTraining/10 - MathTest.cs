using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace UnitTestTraining
{
    [TestFixture]
    public class MathTest
    {
        private Math math { get; set; }

        [SetUp]
        public void SetUp()
        {
            math = new Math();
        }
        [Category("Math")]
        [Category("Add")]
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(2, 1, 3)]
        public void Add_WhenCalled_ReturnTheSum(int a, int b, int expectedResult)
        {
            //Act
            int result = math.Add(a,b);
            //Assert
            Assert.Multiple(() => {
                Assert.AreEqual(expectedResult, result);
                Assert.AreNotEqual(b, result);
            });
            
        }

        [Category("Math")]
        [TestCase(1, 2, ExpectedResult=3)]
        [TestCase(2, 3, ExpectedResult=5)]
        [TestCase(2, 1, ExpectedResult=3)]
        public int Add_WhenCalled_ReturnTheSumAlternative(int a, int b)
        {
            //Act
            return math.Add(a, b);
        }

        [Category("Math")]
        [TestCase(11, 10, ExpectedResult = 11)]
        [TestCase(-2, -1, ExpectedResult = -1)]
        [TestCase(432, 0, ExpectedResult = 432)]
        public int GetGreaterNumber_WhenCalled_ReturnGreaterNumber(int a, int b)
        {
            //Act
            return math.GetGreaterNumber(a, b);
        }

        [Category("Math")]
        [Test]
        public void GetOddNumbers_WhenCalled_ReturnOddNumbers()
        {
            //Arrange
            int limit = 11;
            //Act
            var result = math.GetOddNumbers(limit);
            var result2 = math.GetOddNumbers(limit+1);
            //Assert
            CollectionAssert.AreEquivalent(result2, result);
        }
    }
}
