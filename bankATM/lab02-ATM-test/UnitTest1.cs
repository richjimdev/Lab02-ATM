using System;
using Xunit;
using bankATM;
using static bankATM.Program;

namespace lab02_ATM_test
{
    public class UnitTest1
    {
        [Fact]
        public void GetBalanceReturnsBalance()
        {
            balance = 500;
            Assert.Equal(500, GetBalance());
        }

        [Fact]
        public void WithdrawReturnsDecreasedNumber()
        {
            balance = 500;
            Assert.Equal(450, Withdraw(50));
        }

        [Fact]
        public void GetBalanceReturnsProperBalanceAfterWithdraw()
        {
            balance = 500;
            Withdraw(100);
            Assert.Equal(400, GetBalance());
        }

        [Fact]
        public void DepositReturnsIncreasedNumber()
        {
            balance = 500;
            Assert.Equal(550, Deposit(50));
        }

        [Fact]
        public void GetBalanceReturnsProperBalanceAfterDeposit()
        {
            balance = 500;
            Deposit(100);
            Assert.Equal(600, GetBalance());
        }
        
        }
}
