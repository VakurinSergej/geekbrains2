// Программа, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N

Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (i<=N)
{
Console.WriteLine(" " + i*i);
i++;
}

