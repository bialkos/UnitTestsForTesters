using System;
using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    [TestFixture]
    public class StoreControllerTests
    {
        private StoreController controller;

        [SetUp]
        public void Setup()
        {
            controller = new StoreController();
        }

        [TestCase(0)]
        [TestCase(5)]
        public void GetStore_WhenIdEqualsGreaterOrEqualToZero_ReturnsActionResult(int id)
        {
            var result = controller.GetStore(id);

            // checks if the objects is a given type or its derivate (i.e. is inherited type)
            Assert.That(result, Is.InstanceOf<ActionResult>());
        }

        [Test]
        public void GetStore_WhenIdEqualsToZero_ReturnsNotFoundResult()
        {
            var result = controller.GetStore(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetStore_WhenIdIsGreaterThanZero_ReturnsOkResult()
        {
            var result = controller.GetStore(2);

            Assert.That(result, Is.TypeOf<Ok>());
        }

        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(int.MinValue)]
        public void CalculatePenaltyPoints_WhenSpeedLowerThanZeroOrAboveMaxSpeed_ThrowsArgumentOutOfRangeException(int id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => controller.GetStore(id));
        }
    }
}