// Задача No14. Общее обсуждение
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

if ( (numberA % 7) == 0 & (numberA % 23) == 0)
{
    Console.WriteLine($"Число {numberA} кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine($"Число {numberA} одновременно не кратно 7 и 23");
}