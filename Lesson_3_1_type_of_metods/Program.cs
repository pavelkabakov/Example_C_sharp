// Вид 1 - Метод который ничего не принимает и ничего не возвращает

void Method1() // Описание метода
{
    Console.WriteLine("Метод 1");
}

Method1(); // вызов метода

// Вид 2 - Метод который принимает значение и ничего не возвращает

void Method2(string message) // Описание метода
{
    Console.WriteLine(message);
}

string text = "Метод 2";
Method2(text); // вызов метода

// Вид 3 - Метод который ничего не принимает и возвращает значение чего либо

DateTime Method3() // Описание метода
{
    return DateTime.Now;
}
DateTime date = Method3(); // вызов метода
Console.WriteLine($"Метод 3 выводит дату ничего не получая - {date}"); 


// Вид 4 - Метод который принимает значение и возвращает значение

int Method4(int a) // Описание метода который принимает число и возвращает квадрат числа
{
    return a*a;
}
int number = 6;
int pow2 = Method4(number);
Console.WriteLine($"Метод 4 выводит квадрат числа {number} = {pow2}"); // вызов метода