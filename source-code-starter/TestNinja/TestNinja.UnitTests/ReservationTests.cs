using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]

        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()

        {
            // Arrange 
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);


            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_MadeByUser_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();
            User user = new User();
            reservation.MadeBy = user;
            //Act
            var result = reservation.CanBeCancelledBy(reservation.MadeBy);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdminAndNorMadeBy_ReturnFalse()
        {
            //Arrange
            var user = new User();
            var user1 = new User();
            var reservation = new Reservation { MadeBy = user };
            //Act
            var result = reservation.CanBeCancelledBy(user1);
            //Assert
            Assert.IsFalse(result);

        }

    }
}
