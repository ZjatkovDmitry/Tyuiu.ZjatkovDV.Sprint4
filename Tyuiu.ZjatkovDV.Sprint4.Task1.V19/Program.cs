using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task1.V19.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 12 элементов            *");
Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 9 подсчитать    *");
Console.WriteLine("* сумму четных элементов массива.                                         *");
Console.WriteLine("* С клавиатуры: 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4.                       *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: [6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4]                   *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

int[] x = [6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4];

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();