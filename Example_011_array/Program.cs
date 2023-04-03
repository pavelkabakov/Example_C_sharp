// Имеется одномерный массив array из n элементов, требуется
// найти элемент массива равный find

int [] array = { 1, 2, 12, 32, 4, 14, 34, 67, 87, 44 };

int n = array.Length;
int find = 87;

int index=0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(array[index]);
        break;
    }
index++;
}