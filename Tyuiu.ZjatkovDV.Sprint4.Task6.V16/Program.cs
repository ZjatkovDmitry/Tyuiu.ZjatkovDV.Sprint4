using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task6.V16.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан строковый массив данных [\"Автомобиль\", \"Велосипед\",        *");
Console.WriteLine("* \"Самолет\", \"Поезд\", \"Трамвай\", \"Троллейбус\", \"Метро\"], используя класс  *");
Console.WriteLine("* Array, выведите элементы массива, длина которых равна 7 символам.       *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: [\"Автомобиль\", \"Велосипед\", \"Самолет\", \"Поезд\",        *");
Console.WriteLine("* \"Трамвай\", \"Троллейбус\", \"Метро\"]                                       *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string[] x = ["Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро"];

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.Write("[");
foreach (string c in result.Calculate(x))
{
    Console.Write("\"" + c + "\", ");
}
Console.WriteLine("\b\b]");

Console.WriteLine(new string('*', 75));
Console.ReadKey();