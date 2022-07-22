// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите 3х значное число");
int number = int.Parse (Console.ReadLine( ));
int sacondDigit = (number / 10) % 10;
Console.WriteLine(sacondDigit);
