using Tyuiu.HaevGS.Sprint4.Task4.V2.Lib;

DataService ds = new DataService();

int[,] matrix = new int[5, 5] { { 2, 2, 5, 5, 9 },

                     { 7, 3, 8, 9, 9 },

                     { 6, 7, 9, 3, 5 },

                     { 7, 5, 7, 7, 8 },

                     { 2, 2, 4, 7, 9, } };

int res = matrix.GetUpperBound(0) + 1;
int colums = matrix.Length / res;

for (int i = 0; i < res; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine(ds.Calculate(matrix));
Console.ReadKey();