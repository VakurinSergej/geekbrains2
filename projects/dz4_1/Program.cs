// Цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Без использования Math.Pow

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int result = 1;
int n = 1;
while (n <= b)
{
    result = result*a;
    n++;
}
Console.WriteLine(result);


