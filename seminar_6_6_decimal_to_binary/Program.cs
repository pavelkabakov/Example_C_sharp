// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;
}

Console.WriteLine(Translation(number));

string Translation(int number)
{
    string str = string.Empty;

    while(number != 0)
    {
        str = number%2 + str;
        number /= 2;
    }

    return str;
}
