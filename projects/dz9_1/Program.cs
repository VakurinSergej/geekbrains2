// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(1, n));

string PrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start + " " + PrintNumbers(start + 1, end)); 
}

// вариант 2

// Console.WriteLine("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNumber(n));

// string PrintNumber(int n)
// {
//     if (n == 1) return "1";
//     return (n + " " + PrintNumber(n - 1));
// }
