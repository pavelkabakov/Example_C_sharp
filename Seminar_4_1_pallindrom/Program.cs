// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// вариант 

Console.WriteLine("Введите число, для проверки на паллиндром");
string str = Console.ReadLine();
int length = str.Length;
Console.WriteLine(ConverToArray(str));

array ConverToArray(char[] array)
{
    char[] tmp = new char[length]; 
    for (int i = 0; i < length - 1; i++)
    {
        numbers[i] = str[length - i];
    }
    return;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < length - 1; i++)
    {
        numbers[i] = str[length - i];
    }
}




