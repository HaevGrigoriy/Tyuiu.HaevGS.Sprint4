using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.HaevGS.Sprint4.Task4.V2.Lib
{
    public class DataService : ISprint4Task4V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            int com = matrix.GetLength(0) + 1;
            int st = matrix.Length / com;


            for(int i = 0; i < com; i++)
            {
                for(int j = 0; j < st; j++)
                {
                    if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;
                    
                }
            }
            return matrix;
        }
    }
}
