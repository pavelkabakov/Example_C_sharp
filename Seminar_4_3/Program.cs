// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = 8; // задаем длинну массива
int[] array = new int[number];

FillArrayRandom(number);
PrintArray (array);

int[] FillArrayRandom(int length)
{
Random random = new Random();

    for (int i = 1; i < number; i++)
    {
        int randomValue = random.Next(0, 2);
        array[i]= randomValue;
    }
return array;
}

void PrintArray (int[] array)
{
    for (int i = 1; i < number; i++)
        {
           Console.WriteLine(array[i]);
        }
}

