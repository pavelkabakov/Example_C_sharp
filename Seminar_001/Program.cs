/*
Вводим число
преобразуем строку в число
выводим число
выводим квадрат числа
*/

Console.Write("Введите число - ");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine("Вы ввели - ");
Console.WriteLine(number);
Console.WriteLine("Квадрат числа = ");
Console.WriteLine(number*number);