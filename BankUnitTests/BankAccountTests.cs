using BankUnitTests;
using System;
using NUnit.Framework;


namespace BankUnitTests.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [Test]
        public void Debit_WhenAmountIsSmallerThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=> account.Debit(debitAmount));
        }

        [Test]
        public void Debit_WhenAmountIsGreaterThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and Assert
            Assert.That(() => account.Debit(debitAmount),
            Throws.TypeOf<ArgumentOutOfRangeException>()
                    .With.Message.Contain("Not enough money in the account"));
        }

        [Test]
        public void Debit_WhenAmountIsValidAndAccountIsFrozen_ShouldThrowException()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 20;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.FreezeAccount();

            // Act and Assert
            Assert.That(() => account.Debit(creditAmount),
                Throws.InstanceOf<Exception>());
        }
    }
}