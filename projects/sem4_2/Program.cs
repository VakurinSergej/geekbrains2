// Программа, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N

Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());

int GetMultiply (int a)
{
    int multiply = 1;  
    for (int i=1; i<=a; i++) multiply=multiply*i;
    return multiply;
}

Console.WriteLine(GetMultiply(N));
