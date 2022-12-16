// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);

if (a==b*b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}