using Tyuiu.ZjatkovDV.Sprint4.Task3.V25.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task3.V25.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            int[,] ints = { {7, 3, 5, 3, 6}, {4, 6, 2, 5, 7}, {2, 3, 3, 3, 5}, {2, 7, 7, 6, 2}, {6, 6, 4, 3, 6} };
            Assert.Equal(810, result.Calculate(ints));
        }
    }
}