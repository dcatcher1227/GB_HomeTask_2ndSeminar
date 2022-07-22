// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num <= 99)
{
    Console.WriteLine("Цифры нет ");
}
string s1 = num.ToString();
char ch3 = s1[2];
Console.WriteLine(s1[2]);