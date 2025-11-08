using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZjatkovDV.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int sum = 1;

            foreach (int i in array)
            {
                if (i % 2 == 0)
                    sum *= i;
            }

            return sum;
        }
    }
}
