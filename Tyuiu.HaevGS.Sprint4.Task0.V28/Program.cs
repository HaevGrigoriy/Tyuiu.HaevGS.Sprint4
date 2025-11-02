using Tyuiu.HaevGS.Sprint4.Task0.V28.Lib;

DataService ds = new DataService();

int[] num = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

for (int i = 0; i < num.Length - 1; i++)
{
    Console.WriteLine("Массив: " + num[i]);
}


var result = ds.GetMultEvenArrEl(num);
Console.WriteLine("Произведение = " + result +'\t');
Console.ReadKey();