using Tyuiu.HaevGS.Sprint4.Task2.V16.Lib;


DataService ds =  new DataService();

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    Console.Write("Введите значение " + i + "элемента массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");

for (int i = 0; i <= len - 1; i++)
{
    Console.Write(numsArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine(res);

Console.ReadKey();