/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98
*/

Random randomNumber = new Random();
int randomValue = randomNumber.Next(100, 1000); // генерируем случайное число

int lastDigit = randomValue % 10; // находим остаток от деления и получаем последний разряд
int firstDigit = randomValue / 100 * 10; // получаем первый разряд
int newValue = lastDigit + firstDigit; 

Console.WriteLine(randomValue);
Console.WriteLine(newValue);
