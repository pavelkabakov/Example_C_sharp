/*
Задача No1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

*/

// Вводим два числа
Console.Write("Введите число номер один - ");
string input_1 = Console.ReadLine();
// преобразуем строку 1 в число
int number_1 = int.Parse(input_1);

Console.Write("Введите число два - ");
string input_2 = Console.ReadLine();
// преобразуем строку 2 в число
int number_2 = int.Parse(input_2);

Console.WriteLine("первое число - ");
Console.WriteLine(number_1);
Console.WriteLine("Второе число - ");
Console.WriteLine(number_2);

if ((number_1 * number_1) == number_2)
{
    Console.WriteLine("Число номер 1 является квадратом второго");
}
else
{
    Console.WriteLine("Число номер 1 не является квадратом второго");
}

