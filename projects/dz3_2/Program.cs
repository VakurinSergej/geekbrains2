// Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите первое число: ");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double za = double.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число: ");

double xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите пятое число: ");
double yb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите шестое число: ");
double zb = double.Parse(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine(ab);
