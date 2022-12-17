// Программа, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.


Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int N1 = (N) * (-1);

 while (N1 <= N)
{
    Console.WriteLine(N1);
    N1++;

}
