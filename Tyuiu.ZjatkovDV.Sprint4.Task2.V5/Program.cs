using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task2.V5.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 14 элементов            *");
Console.WriteLine("* заполненный случайными в диапазоне от 3 до 9 подсчитать произведение    *");
Console.WriteLine("* четных элементов массива.                                               *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

int[] x = new int[14];

for (int i = 0; i < x.Length; i++)
{
    Console.Write($"Введите {i+1} (из 14) элемент массива: ");
    x[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();