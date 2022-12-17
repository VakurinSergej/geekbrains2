// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = (a % 100) / 10;
Console.WriteLine(b);
