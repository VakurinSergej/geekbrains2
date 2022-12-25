// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите первое число: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число: ");
double k2 = double.Parse(Console.ReadLine());

double x = ((b2-b1)/(k1-k2));
Console.WriteLine($"x равен" + x);

double y1 = ((k1*x)+b1);
double y2 = ((k2*x)+b2);
Console.WriteLine($"Координаты точки пересечения двух прямы:" + (y1, y2));

