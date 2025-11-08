using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZjatkovDV.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17 
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int result = 0, counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(value[counter]);
                    counter++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        result++;
                }
            }

            return result;
        }
    }
}
