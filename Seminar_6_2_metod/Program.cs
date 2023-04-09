/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.WriteLine("Введите сторону треугольника 1");
int tmp1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону треугольника 2");
int tmp2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону треугольника 3");
int tmp3 = int.Parse(Console.ReadLine());

Console.WriteLine(Find(tmp1, tmp2, tmp3));

string Find(int tmp1, int tmp2, int tmp3)
{
    string str;

    if (tmp1 < tmp2 + tmp3 && tmp2 < tmp1 + tmp3 && tmp3 < tmp1 + tmp2)
    {
        str = "Треугольник существует";
    }
    else
    {
        str = "Треугольник не существует";
    }

    return str;
}






