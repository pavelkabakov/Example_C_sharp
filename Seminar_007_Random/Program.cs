/*
выводит случайное число от 10 до 99, пока не выскочит 66
*/

Random randomNumber = new Random();
int randomValue = randomNumber.Next(10, 100);
int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);
Console.WriteLine(lastDigit);
Console.WriteLine(firstDigit);



/*
while (randomValue != 66)
{
randomValue = random.Next(10, 100);
Console.WriteLine(randomValue);
}
*/