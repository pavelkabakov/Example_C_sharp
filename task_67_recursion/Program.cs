
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

Console.WriteLine("Введите число");

bool isParsedn = int.TryParse(Console.ReadLine(), out int number);
if (!isParsedn) { Console.WriteLine("Ошибка ввода"); return; }
Console.WriteLine($"Вы ввели число - {number}");

Console.WriteLine(Summ_Digits(number));


int Summ_Digits(int number)
{
    if (number <= 0) { return 0; }
    int summ = number % 10;
    number = number / 10;

    return Summ_Digits(number) + summ;
}