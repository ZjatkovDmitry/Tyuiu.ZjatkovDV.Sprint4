using Tyuiu.ZjatkovDV.Sprint4.Task1.V19.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task1.V19.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(32, result.Calculate([6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4]));
        }
    }
}