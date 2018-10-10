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
        public void WithdrawModifiesBalance()
        {
            Assert.Equal(450, Withdraw(50));
        }

        [Fact]
        public void GetBalanceReturnsBalanceAfterModification()
        {
            Assert.Equal(450, GetBalance());
        }
    }
}
