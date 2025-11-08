using Tyuiu.ZjatkovDV.Sprint4.Task2.V5.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task2.V5.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(16, result.Calculate([1, 4, 4, 5]));
        }
    }
}