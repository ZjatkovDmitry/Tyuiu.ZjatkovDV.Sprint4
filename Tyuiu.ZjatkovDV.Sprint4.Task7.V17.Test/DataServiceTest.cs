using Tyuiu.ZjatkovDV.Sprint4.Task7.V17.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task7.V17.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(3, result.Calculate(3, 3, "753159864"));
        }
    }
}