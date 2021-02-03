using System;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    [TestFixture]
    class PenaltyPointsCalculatorTests
    {
        private PenaltyPointsCalculator penaltyPointsCalculator;

        [SetUp]
        public void Setup()
        {
            penaltyPointsCalculator = new PenaltyPointsCalculator();
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(301)]
        [TestCase(50000)]
        public void CalculatePenaltyPoints_WhenSpeedLowerThanZeroOrAboveMaxSpeed_ThrowsArgumentOutOfRangeException(int speed)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => penaltyPointsCalculator.CalculatePenaltyPoints(speed));
        }

        [TestCase(0)]
        [TestCase(34)]
        [TestCase(65)]
        public void CalculatePenaltyPoints_WhenSpeedWithinLimit_ReturnsZero(int speed)
        {
            var result = penaltyPointsCalculator.CalculatePenaltyPoints(speed);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(71,1)]
        [TestCase(85, 4)]
        public void CalculatePenaltyPoints_WhenSpeedGreaterThanZero_ReturnsOnePointForEachFiveKmphAboveLimit(int speed, int expectedPenaltyPoints)
        {
            var result = penaltyPointsCalculator.CalculatePenaltyPoints(speed);
            Assert.That(result, Is.EqualTo(expectedPenaltyPoints));
        }
    }   
}
