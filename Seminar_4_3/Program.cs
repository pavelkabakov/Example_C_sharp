// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 5 -> 120

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int number = 8; // задаем число символов
int[] array = new int[number];

Random random = new Random();

    for (int i = 1; i < number; i++)
    {
        int randomValue = random.Next(0, 2);
        array[i]= randomValue;
    }

PrintArray (array);

void PrintArray (int[] array)
{
    for (int i = 1; i < number; i++)
        {
           Console.WriteLine(array[i]);
        }
}

