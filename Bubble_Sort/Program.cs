/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
// Console.WriteLine("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine());
using System.Diagnostics;
int n = 50000;
bool show = false;
int[] array1 = new int[n];
if (show) Console.WriteLine("Начальный массив: [" + string.Join(", ", FillArrayRandom(array1)) + "]");
Console.WriteLine(Check(array1));
int[] array2 = new int[n];
Array.Copy(array1, array2, n);
int[] array3 = new int[n];
Array.Copy(array1, array3, n);

Stopwatch sw = new Stopwatch();
sw.Start();
BubbleSort1(array1);
if (show) Console.WriteLine("Отсортированный массив вар_1: [" + string.Join(", ", array1) + "]");
sw.Stop();
Console.WriteLine($"Тест сортировки: {Check(array1)}, Время: {sw.ElapsedMilliseconds}, ms");
sw.Reset();
sw.Start();
BubbleSort2(array2);
if (show) Console.WriteLine("Отсортированный массив вар_2: [" + string.Join(", ", array2) + "]");
sw.Stop();
Console.WriteLine($"Тест сортировки: {Check(array2)}, Время: {sw.ElapsedMilliseconds}, ms");
sw.Reset();
sw.Start();
BubbleSort3(array3);
if (show) Console.WriteLine("Отсортированный массив вар_3: [" + string.Join(", ", array3) + "]");
sw.Stop();
Console.WriteLine($"Тест сортировки: {Check(array2)}, Время: {sw.ElapsedMilliseconds}, ms");

// buble sort classic вариант 1
void BubbleSort1(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
}

// buble sort оптимизированный вариант 2
void BubbleSort2(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1-i; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
}

// buble sort оптимизированный вариант 3
void BubbleSort3(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
}

// заполнение массива случайными числами
int[] FillArrayRandom(int[] array)
{
Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        int randomValue = random.Next(0, 100);
        array[i]= randomValue;
    }
return array;
}
// тест сортировки массива
bool Check(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] > array[i+1]) return false;               
    }
    return true;
}