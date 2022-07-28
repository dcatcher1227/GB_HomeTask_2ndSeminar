// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

// Упрощенное решение
Console.WriteLine("Введите цифру от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day ==7)
{
    Console.Write("да");
}
Console.Write("нет");

// Развернутое решение.

Console.WriteLine("Введите цифру от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{
    Console.Write("Понедельник - день рабочий");
}
if (day == 2)
{
    Console.Write("Вторник - день рабочий");
}
if (day == 3)
{
    Console.Write("Среда - день рабочий");
}
if (day == 4)
{
    Console.Write("четверг - день рабочий");
}
if (day == 5)
{
    Console.Write("Пятница - день рабочий");
}
if (day == 6)
{
    Console.Write("Суббота - Выходной");
}
if (day == 7)
{
    Console.Write("Воскресенье - Выходной");
}
if (day == 0)
{
    Console.Write("Нет такого дня недели ");
}


