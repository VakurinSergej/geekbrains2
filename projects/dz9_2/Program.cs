// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(n, m));


int PrintNumber(int n, int m)
{
    if (n == m) return n;
    return (n + PrintNumber(n + 1, m));
}
