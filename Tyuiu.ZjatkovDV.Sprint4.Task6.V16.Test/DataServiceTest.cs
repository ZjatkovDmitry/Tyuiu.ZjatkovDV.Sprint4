using Tyuiu.ZjatkovDV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task6.V16.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(["Самолет", "Трамвай"], result.Calculate(["Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро"]));
        }
    }
}