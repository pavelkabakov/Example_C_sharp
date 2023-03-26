/*
метод и форматирование строки
*/

int a=5;

int b=6;

string tmp = $"число 1 = {a} число 2 = {b}";

Console.Clear();
Console.WriteLine(Calculate(a, b));
Console.WriteLine(tmp);

int Calculate (int a, int b)
{
    return a * b;
}
