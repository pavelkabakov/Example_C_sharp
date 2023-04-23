// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите N:");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN) { Console.WriteLine("Ошибка ввода, введено не число"); return; }
Print(n);
void Print(int n, int start = 1)
{
    if (start > n) { return; }
    Console.WriteLine(start);
    start++;

    Print(n, start);
}
