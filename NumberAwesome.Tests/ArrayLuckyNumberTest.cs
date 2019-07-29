using NumberAwesome.Console.Numbers;
using Xunit;

namespace NumberAwesome.Tests
{
    public class ArrayLuckyNumberTest
    {
        public ArrayLuckyNumberTest() { }

        [Fact]
        public void Test_Numero_777777_E_Numero_Sortudo()
        {
            var luckyNumber = new ArrayLuckyNumber(777777);
            Assert.True(luckyNumber.IsLucky());
        }
    }
}
