using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZjatkovDV.Sprint4.Task0.V8.Lib
{
    public class DataService : ISprint4Task0V8
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int sum = 0;

            foreach (int i in array)
            {
                if (i % 2 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
