/*
Задача No5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

// Вводим число
Console.Write("Введите число - ");
string input1 = Console.ReadLine();
// преобразуем строку 1 в число
int number1 = int.Parse(input1);
int a = number1;
int b = -number1;
while (b <= number1)
{
    Console.Write(b);
    Console.Write(" ");
    b = b + 1;
}




