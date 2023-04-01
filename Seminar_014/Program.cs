using System;

// Задача No18. Общее обсуждение
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int x = int.Parse(Console.ReadLine());
Console.WriteLine($"Вы ввели {x}");

string range = RangeQuarter(x);
Console.WriteLine($"Диапазон для {x} четверти - {range}");

string RangeQuarter (int x)
{
    if (x == 1)
    {
        return range = "x>0 and y>0 ";
    }
    else if (x == 2)
    {
        return range = "x<0 and y>0 ";
    }
    else if (x == 3)
    {
        return range = "x<0 and y<0 ";
    }
    else if (x == 4)
    {
        return range = "x>0 and y<0 ";
    }
    return "неверное значение";
}
