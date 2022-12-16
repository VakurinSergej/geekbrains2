// Задача показать квадрат числа

// вариант1
// int a = new Random().Next(1,15);
// Console.Write("выбрано число: ");
// Console.WriteLine(a);
// Console.Write("квадрат числа: ");
// Console.WriteLine(a*a);

// вариант2
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int result = a*a;
Console.Write("квадрат числа = ");
Console.WriteLine(a*a);
