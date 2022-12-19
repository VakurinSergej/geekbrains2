//  Программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a > 100 && a < 1000)
{
int b = (a % 10);
Console.Write("Третья цифра числа: ");
Console.WriteLine(b);
}
if (a < 100)
{
Console.Write("Третьей цифры нет");
}
