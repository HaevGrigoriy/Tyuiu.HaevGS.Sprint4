using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.HaevGS.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int res = array.GetUpperBound(0) + 1;
            int colums = array.Length / res;
            int count = 0;

            for(int i = 1; i < res; i)
            {
                for(int j = 1; j < colums; j)
                {
                    if(array[i, j] == 8)
                    {
                        count += array[i,j];
                    }
                }
            }
            return count;
        }
    }
}
