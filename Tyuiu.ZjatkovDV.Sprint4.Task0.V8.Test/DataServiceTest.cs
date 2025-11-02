using Tyuiu.ZjatkovDV.Sprint4.Task0.V8.Lib;

namespace Tyuiu.ZjatkovDV.Sprint4.Task0.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMultEvenArrEl()
        {
            var result = new DataService();
            Assert.Equal(384, result.GetMultEvenArrEl([1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9]));
        }
    }
}