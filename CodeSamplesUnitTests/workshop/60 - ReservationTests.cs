using NUnit.Framework;
using UnitTestsFortTesters;

namespace Tests
{
    public class ReservationTests
    {
        private Reservation reservation;
        private User user;

        [SetUp]
        public void Setup()
        {
            reservation = new Reservation();
            user = new User();
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            user.IsAdmin = true;
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdminAndNotHisReservation_ReturnsFalse()
        {
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsFalse(result);
        }

        [Test]
        public void CanBeCancelledBy_UserWhoMadeReservation_ReturnsTrue()
        {
            reservation.MadeBy = user;
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }
    }
}