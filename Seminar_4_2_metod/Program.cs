// Задача 24
// напишите программу которая принимает на вход число А
// и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int sum = GetSumToNumber(a);
Console.WriteLine(sum);

int GetSumToNumber(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

