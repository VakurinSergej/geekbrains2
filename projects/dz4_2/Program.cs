// Программа, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int sum = 0;

for (int i = 0; i <number.Length; i++) 
{
     sum = sum + Convert.ToInt32(number[i]);
}
Console.WriteLine(sum);




