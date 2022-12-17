// Программа, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число не кратно числу первому, 
// то программа выводит остаток от деления


Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число:");
int b = int.Parse(Console.ReadLine()!);

if (a%b==0)
{
    Console.WriteLine("число кратно");
}
else
{
    Console.Write("число не кратно,остаток: ");
    Console.WriteLine(a%b);
}
