// See https://aka.ms/new-console-template for more information

int[] arr = new int[]{1, 2, 3, 4, 5};

PrintArray(arr);
int[] reversed = Reverse(arr)

int[] reversed(int[] array)
// {
//     int[] reversed
// }

void Reverse(int[] array)
{
    for (int i = 0; i < array.length; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 - i] = tmp;
    }
}