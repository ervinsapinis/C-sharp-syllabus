using Xunit;
using Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Tests
{
    public class AccountTests
    {
        private Account _target = new Account("Schweizer Konto von Testface", 1000);

        [Fact()]
        public void Balance_ShouldReturnBalance()
        {
            //Arrange
            var expected = 1000;
            //Act
            var actual = _target.Balance();
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact()]
        public void Withdrawal_ValidAmount_ShouldReturnWithdrawalMessageWithValidAmount()
        {
            //Arrange
            var expected = "A withdrawal of 100 from Schweizer Konto von Testface is made.";
            //Act
            var actual = _target.Withdrawal(100);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Withdrawal_ValidAmount_ShouldReduceAmount()
        {
            //Arrange
            var expected = 900;
            _target.Withdrawal(100);
            //Act
            var actual = _target.Balance();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Withdrawal_InValidAmount_ShouldReturnError()
        {
            //Arrange
            var expected = "Not enough money to make a withdrawal!";
            //Act
            var actual = _target.Withdrawal(1500);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Withdrawal_inValidAmount_ShouldNotReduceAmount()
        {
            //Arrange
            var expected = 1000;
            _target.Withdrawal(1500);
            //Act
            var actual = _target.Balance();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Deposit_ValidInput_PrintSuccessfulDepositMessage()
        {
            //Arrange
            var expected = "A deposit of 100 to Schweizer Konto von Testface is made.";
            //Act
            var actual = _target.Deposit(100);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Deposit_InvalidInput_PrintError()
        {
            //Arrange
            var expected = "Can't make a deposit with a negative value.";
            //Act
            var actual = _target.Deposit(-100);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Deposit_ValidInput_ShouldIncreaseAmount()
        {
            //Arrange
            var expected = 1100;
            _target.Deposit(100);
            //Act
            var actual = _target.Balance();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Deposit_InvalidInput_ShouldNotChangeAmount()
        {
            //Arrange
            var expected = 1000;
            _target.Deposit(-100);
            //Act
            var actual = _target.Balance();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Transfer_ValidInput_ShouldReturnSuccessfulTransferMessage()
        {
            //Arrange
            Account testface = new Account("Testface's American Express", 0);
            var expected =
                "100$ successfully transferred from Schweizer Konto von Testface to Testface's American Express";
            //Act
            var actual = _target.Transfer(testface, 100);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Transfer_InvalidInput_ShouldReturnError()
        {
            //Arrange
            Account testface = new Account("Testface's American Express", 0);
            var expected = "Not enough money to make this transfer.";
            //Act
            var actual = _target.Transfer(testface, 123400);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void Transfer_ValidInput_ShouldReduceAmountFromSenderAccAndIncreaseAmountToReceiverAccount()
        {
            //Arrange
            Account testface = new Account("Testface's American Express", 0);
            _target.Transfer(testface, 100);
            var expected1 = 900;
            var expected2 = 100;
            //Act
            var actual1 = _target.Balance();
            var actual2 = testface.Balance();
            //Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
        }

        [Fact()]
        public void Transfer_InvalidInput_ShouldNotReduceAmountFromSenderAccAndIncreaseAmountToReceiverAccount()
        {
            //Arrange
            Account testface = new Account("Testface's American Express", 0);
            _target.Transfer(testface, 14900);
            var expected1 = 1000;
            var expected2 = 0;
            //Act
            var actual1 = _target.Balance();
            var actual2 = testface.Balance();
            //Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
        }
    }
}