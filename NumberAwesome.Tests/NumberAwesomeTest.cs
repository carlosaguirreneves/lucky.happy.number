using NumberAwesome.Console.Numbers;
using Xunit;

namespace NumberAwesome.Tests
{
    public class NumberAwesomeTest
    {
        public NumberAwesomeTest() { }

        [Fact]
        public void Test_Number_7_IsLucky_And_IsHappy()
        {
            var luckyNumber = new ArrayLuckyNumber(7);
            Assert.True(luckyNumber.IsLucky());

            var happyNumber = new HappyNumber(7);
            Assert.True(happyNumber.IsHappy());

        }

        [Fact]
        public void Test_Number_21_IsLucky_And_IsNotHappy()
        {
            var luckyNumber = new ArrayLuckyNumber(21);
            Assert.True(luckyNumber.IsLucky());

            var happyNumber = new HappyNumber(21);
            Assert.False(happyNumber.IsHappy());
        }

        [Fact]
        public void Test_Number_28_IsNotLucky_And_IsHappy()
        {
            var luckyNumber = new ArrayLuckyNumber(28);
            Assert.False(luckyNumber.IsLucky());

            var happyNumber = new HappyNumber(28);
            Assert.True(happyNumber.IsHappy());
        }

        [Fact]
        public void Test_Number_142_IsNotLucky_And_IsNotHappy()
        {
            var luckyNumber = new ArrayLuckyNumber(142);
            Assert.False(luckyNumber.IsLucky());

            var happyNumber = new HappyNumber(142);
            Assert.False(happyNumber.IsHappy());
        }

        [Fact]
        public void Test_Number_37_IsLucky_And_IsNotHappy()
        {
            var luckyNumber = new ArrayLuckyNumber(37);
            Assert.True(luckyNumber.IsLucky());

            var happyNumber = new HappyNumber(37);
            Assert.False(happyNumber.IsHappy());
        }

        [Fact]
        public void Test_Number_100_IsNotLucky_And_IsHappy()
        {
            var luckyNumber = new ArrayLuckyNumber(100);
            Assert.False(luckyNumber.IsLucky());

            var happyNumber = new HappyNumber(100);
            Assert.True(happyNumber.IsHappy());
        }
    }
}
