// Задача No16. Работа в группах
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// ● 5, 25 -> да 
// ● -4, 16 -> да
// ● 25, 5 -> да 
// ● 8,9 -> нет

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else if (numberB * numberB == numberA)
{
    Console.WriteLine($"Число {numberB} является квадратом числа {numberA}");

}
else
{
    Console.WriteLine($"Числа {numberB} и {numberA} не являются квадратами друг друга");
}