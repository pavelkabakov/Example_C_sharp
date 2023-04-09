Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;
}