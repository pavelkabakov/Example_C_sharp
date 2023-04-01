using System.Globalization;
// Задача No22. Работа в группах
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

GetPowTable(number);

void GetPowTable (int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i, 2));
    }
    
}
