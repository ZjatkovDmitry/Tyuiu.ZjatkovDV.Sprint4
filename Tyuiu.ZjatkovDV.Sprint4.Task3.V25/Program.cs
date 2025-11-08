using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task3.V25.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5 элементов,           *");
Console.WriteLine("* заполненный статическими значениями в диапазоне от 2 до 7. Найдите      *");
Console.WriteLine("* произведение элементов в четвертом столбце массива.                     *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: { {7, 3, 5, 3, 6},                                     *");
Console.WriteLine("*                    {4, 6, 2, 5, 7},                                     *");
Console.WriteLine("*                    {2, 3, 3, 3, 5},                                     *");
Console.WriteLine("*                    {2, 7, 7, 6, 2},                                     *");
Console.WriteLine("*                    {6, 6, 4, 3, 6} }                                    *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

int[,] x = { { 7, 3, 5, 3, 6 }, { 4, 6, 2, 5, 7 }, { 2, 3, 3, 3, 5 }, { 2, 7, 7, 6, 2 }, { 6, 6, 4, 3, 6 } };

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();