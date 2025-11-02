using Tyuiu.HaevGS.Sprint4.Task1.V8.Lib;

DataService ds = new DataService();

int len;
len = Convert.ToInt32(Console.ReadLine());

int[] num = new int[len];

for (int i = 0; i < len-1; i++)
{
    num[i] = Convert.ToInt32(Console.ReadLine());
}
Console.ReadKey();