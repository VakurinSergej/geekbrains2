// Программа, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int n = number.Length;
int sum = 0;

for (int i=0; i<n; i++) 
{
     sum = sum + number[i];
}
Console.WriteLine(sum);


