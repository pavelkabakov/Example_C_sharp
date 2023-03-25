/*
Задача No3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
20 минут
*/

// Вводим число
Console.Write("Введите число дня недели - ");
string input1 = Console.ReadLine();

if ((input1) == "1")
{
    Console.WriteLine("Сегодня Понедельник");
}
if ((input1) == "2")
{
    Console.WriteLine("Сегодня Вторник");
}
if ((input1) == "3")
{
    Console.WriteLine("Сегодня Среда");
}
if ((input1) == "4")
{
    Console.WriteLine("Сегодня Четверг");
}
if ((input1) == "5")
{
    Console.WriteLine("Сегодня Пятница");
}
if ((input1) == "6")
{
    Console.WriteLine("Сегодня Суббота");
}
if ((input1) == "7")
{
    Console.WriteLine("Сегодня Воскресенье");
}
