Console.WriteLine("Введите x:");
int x = int.Parse(Console.Readline());
Console.WriteLine("Введите y:");
int y = int.Parse(Console.Readline());

int result = GetNumberOfQuarter (x, y);
Console.WriteLine($"X and Y are in {result} quarter");

int GetNumberOfQuarter (int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }    

    if (y > 0 && x < 0)
    {
        return 2;
    }    

    if (x > 0 && y > 0)
    {
        return 3;
    }    

    if (x > 0 && y < 0)
    {
        return 4;
    }     

    return 0;
}


