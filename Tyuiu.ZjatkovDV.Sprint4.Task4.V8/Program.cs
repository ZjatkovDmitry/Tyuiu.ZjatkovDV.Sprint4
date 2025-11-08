using System.Text;
using Tyuiu.ZjatkovDV.Sprint4.Task4.V8.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #4 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5 элементов,           *");
Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 6. Заменить     *");
Console.WriteLine("* четные элементы массива на 1.                                           *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

int[,] x = new int[5, 5];

for (int i = 0; i < x.GetLength(0); i++)
{
    for (int j = 0; j < x.GetLength(1); j++)
    {
        Console.Write($"Введите {j + 1}-ый (из 5) элемент {i + 1}-ой (из 5) строки массива: ");
        x[i, j] = Convert.ToInt32(Console.ReadLine());
    }
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