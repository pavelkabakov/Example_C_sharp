/*
Задача No7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6 782 -> 2 918 -> 8
*/

Console.Write("Введите число - ");
string input1 = Console.ReadLine();
// преобразуем строку 1 в число
int number1 = int.Parse(input1);
int ostatok = (number1 - number1 / 10*10);
Console.Write("Последняя цифра числа - ");
Console.Write(ostatok);
