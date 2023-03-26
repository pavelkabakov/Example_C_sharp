/*int a = 5;
int b = 6;
int c = 7;
int g = 8;
int result1 = Calculate(a, b);
Show(a,b);
int result2 = Calculate(c, g);
Show(c,g);
Console.WriteLine(result1);
Console.WriteLine(result2);
int Calculate(int a, int b)
{
    int result = a * (a * b) - 5;
    
    return result;
}
void Show(int a, int b)
{
    Console.WriteLine($"{a} , {b}");
}*/

/*int y = 10;
string str = "lalalal";
char ch = 'c';
double db = 1.4;
bool bl = false;
string tmp = $"{y} - лалалал {str} fldsfdsfsdf {ch} - sdflnsdf s{db} {bl}";
string tmp2 = y + " - лалалал " + str + " fldsfdsfsdf " + " - sdflnsdf s";
Console.WriteLine(tmp);*/


// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// Например:
// ● 78 -> 8
// ● 12-> 2
// ● 85 -> 8

Random random = new Random();
int randomValue = random.Next(10, 100);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);

if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else{
    Console.WriteLine(firstDigit);
}
int b = 5;