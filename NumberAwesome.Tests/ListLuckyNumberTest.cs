using NumberAwesome.Console.Numbers;
using Xunit;

namespace NumberAwesome.Tests
{
    public class ListLuckyNumberTest
    {
        public ListLuckyNumberTest() { }

        [Fact]
        public void Test_Numero_777777_E_Numero_Sortudo()
        {
            var luckyNumber = new ListLuckyNumber(777777);
            Assert.True(luckyNumber.IsLucky());
        }
    }
}
