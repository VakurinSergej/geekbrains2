// Напишите программу, которая принимает на вход число N 
// и выдаёт сумму чисел от 1 до N

// вариант 1 - математический

// Console.Write("-> ");
// double N = double.Parse(Console.ReadLine()!);
// Console.Write((1 + N) * (N / 2));

// вариант 2 - более простой
Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
for (int i=1; i<=N; i++) 
{
sum=sum+i;
}
Console.WriteLine(sum);
