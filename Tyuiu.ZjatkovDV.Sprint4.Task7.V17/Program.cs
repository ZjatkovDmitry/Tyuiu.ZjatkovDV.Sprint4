using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task7.V17.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дана строка из одноразрядных цифр \"753159864\". Преобразуйте    *");
Console.WriteLine("* ее в матрицу 3 на 3 и подсчитайте количество четных чисел               *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: \"753159864\"                                            *");
Console.WriteLine(new string('*', 75));

var result = new DataService();
string value = "753159864";
int counter = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("{0,1:d}, ", value[counter]);
        counter++;
    }
    Console.WriteLine();
}

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.Calculate(3, 3, value).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();