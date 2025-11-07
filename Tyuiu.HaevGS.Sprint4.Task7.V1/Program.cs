using Tyuiu.HaevGS.Sprint4.Task7.V1.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Хасанов Г. С. | ПКТБ 25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Хаев Григорий Сергеевич    | ПКТБ - 25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"135792468\". Преобразуйте ее в      *");
Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string str = "135792468";
Console.WriteLine("Исходная строка: " + str);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
var result = ds.Calculate(3, 3, str);
Console.WriteLine("Количество четных чисел: " + result);

Console.ReadKey();