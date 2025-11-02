using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.HaevGS.Sprint4.Task0.V28.Lib
{
    public class DataService : ISprint4Task0V28
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count *= array[i];
                }
            }
            return count;
        }
    }
}
