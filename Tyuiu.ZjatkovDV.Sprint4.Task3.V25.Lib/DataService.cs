using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZjatkovDV.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int sum = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum *= array[i, 3];
            }   

            return sum;
        }
    }
}
