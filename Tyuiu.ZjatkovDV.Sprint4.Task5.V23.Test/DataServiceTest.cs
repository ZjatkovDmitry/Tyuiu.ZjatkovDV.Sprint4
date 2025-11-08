using Tyuiu.ZjatkovDV.Sprint4.Task5.V23.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task5.V23.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            int[,] ints = { { -4, -2, 0, 2, 5 }, { 6, 1, 5, -1, -2 } };
            int[,] intsResult = { { 0, 0, 0, 2, 5 }, { 6, 1, 5, 0, 0 } };
            Assert.Equal(intsResult, result.Calculate(ints));
        }
    }
}