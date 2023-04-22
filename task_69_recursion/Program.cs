// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

Console.WriteLine("Введите число:");
int a = DataInput();

Console.WriteLine("Введите его степень:");
int b = DataInput();

int result = PowElement(a, b);

Console.WriteLine(result);

// Рекурсивный метод возведения числа в степень
int PowElement(int a, int b)
{
    if (b <= 0) { return 1; }

    b--;

    return PowElement(a, b) * a;

}

// Рекурсивный метод проверки правильности ввода значения в консоль
int DataInput()
{
    
    bool status = int.TryParse(Console.ReadLine(), out int a);
    if (status) {return a;}
    
    if (!status)
    {
        Console.WriteLine("Введено не число, повторите ввод");
    }

    return DataInput();

}