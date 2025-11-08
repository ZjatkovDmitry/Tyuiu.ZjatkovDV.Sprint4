using Tyuiu.ZjatkovDV.Sprint4.Task4.V8.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task4.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            int[,] ints = { { 1, 3, 2, 2, 5 }, { 6, 1, 5, 5, 2 }, { 1, 5, 4, 1, 4 }, { 4, 1, 4, 4, 5 }, { 4, 6, 1, 1, 4 } };
            int[,] intsResult = { { 1, 3, 1, 1, 5 }, { 1, 1, 5, 5, 1 }, { 1, 5, 1, 1, 1 }, { 1, 1, 1, 1, 5 }, { 1, 1, 1, 1, 1 } };
            Assert.Equal(intsResult, result.Calculate(ints));
        }
    }
}