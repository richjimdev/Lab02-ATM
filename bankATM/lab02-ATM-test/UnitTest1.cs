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
            Assert.Equal(500, GetBalance());
        }
    }
}
