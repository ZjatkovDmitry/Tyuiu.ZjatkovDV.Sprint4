using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task5.V23.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5 элементов,           *");
Console.WriteLine("* заполненный случайными значениями в диапазоне от -4 до 8. Заменить      *");
Console.WriteLine("* отрицательные элементы на 0.                                            *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

int[,] x = new int[5, 5];

for (int i = 0; i < x.GetLength(0); i++)
{
    for (int j = 0; j < x.GetLength(1); j++)
    {
        int number = new Random().Next(-4, 9);
        Console.Write("{0,2:d}, ", number);
        x[i, j] = number;
    }
    Console.WriteLine();
}

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
int[,] resultInts = result.Calculate(x);

for (int i = 0; i < resultInts.GetLength(0); i++)
{
    for (int j = 0; j < resultInts.GetLength(1); j++)
    {
        Console.Write($"{resultInts[i, j]}, ");
    }
    Console.WriteLine();
}

Console.WriteLine(new string('*', 75));
Console.ReadKey();