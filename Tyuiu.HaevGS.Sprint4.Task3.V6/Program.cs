using Tyuiu.HaevGS.Sprint4.Task3.V6.Lib;

DataService ds = new DataService();

int[,] array = new int[5, 5] { { 8, 8, 3, 4, 5 },

                     { 8, 6, 6, 4, 6 },

                     { 3, 6, 5, 3, 4 },

                     { 5, 6, 3, 7, 5 },

                     { 7, 8, 5, 6, 6, } };

int res = array.GetUpperBound(0) + 1;
int colums = array.Length / res;

for (int i = 0; i < res; i++)
{ 
    for (int j = 0; j < colums; j++)
    {
        Console.WriteLine($"{array[i,j]} \t");
    }
    Console.WriteLine();
}

int res = ds.Calculate(array);
Console.ReadKey();