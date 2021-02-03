using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace UnitTestTraining
{
    [TestFixture]
    public class PenaltyPointsCalculatorTest
    {
        private PenaltyPointsCalculator penaltyPointsCalculator { get; set; }

        [SetUp]
        public void SetUp()
        {
            penaltyPointsCalculator = new PenaltyPointsCalculator();
        }

        [Category("PenaltyPointsCalculator")]
        [TestCase(-687)]
        [TestCase(-1)]
        [TestCase(301)]
        [TestCase(4976)]
        public void CalculatePenaltyPoints_ThrowsException(int value)
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> { penaltyPointsCalculator.CalculatePenaltyPoints(value); });
        }

        [Category("PenaltyPointsCalculator")]
        [TestCase(0)]
        [TestCase(12)]
        [TestCase(45)]
        [TestCase(65)]
        public void CalculatePenaltyPoints_ReturnNoPenaltyPoints(int value)
        {
            //Act
            int penaltyPoints = penaltyPointsCalculator.CalculatePenaltyPoints(value);

            //Assert
            Assert.That(penaltyPoints, Is.EqualTo(0)); 
        }

        [Category("PenaltyPointsCalculator")]
        [TestCase(70, ExpectedResult = 1)]
        [TestCase(100, ExpectedResult = 7)]
        [TestCase(255, ExpectedResult = 38)]
        [TestCase(300, ExpectedResult = 47)]
        public int CalculatePenaltyPoints_ReturnPenaltyPoints(int value)
        {
            //Assert
            return penaltyPointsCalculator.CalculatePenaltyPoints(value);
        }
    }
}
