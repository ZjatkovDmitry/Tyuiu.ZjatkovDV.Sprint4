using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task0.V8.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 10 элементов            *");
Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9 подсчитать    *");
Console.WriteLine("* произведение четных элементов массива.  {1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}  *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: {1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}                         *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

int[] x = [1, 6, 3, 7, 5, 4, 2, 7, 8, 9];

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.GetMultEvenArrEl(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();