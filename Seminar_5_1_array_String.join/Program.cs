//Демонстрация решения
//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = GenerateArray(12);
PrintArray(array);

int sum = CalculatePositiveSum(array);
int sumNegativeNumbers = CalculateNegativeSum(array);
Console.WriteLine($"Сумма положительных равна {sum}");
Console.WriteLine($"Сумма отрицательных равна{sumNegativeNumbers}");


int[] GenerateArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


int CalculateNegativeSum(int[] array)
{
    int sumNegative = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] < 0){
            sumNegative+=array[i];
        }
    }

    return sumNegative;
}

int CalculatePositiveSum(int[] array)
{
    int sumPositive = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            sumPositive+=array[i];
        }
    }

    return sumPositive;
}