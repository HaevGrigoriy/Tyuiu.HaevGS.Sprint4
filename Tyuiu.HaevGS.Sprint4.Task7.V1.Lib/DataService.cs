using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.HaevGS.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[n, m] = int.Parse(value[n * 3 + m].ToString());
                    if (n % 2 == 0) count += 1;
                }
            }
            return count;
        }
    }
}
