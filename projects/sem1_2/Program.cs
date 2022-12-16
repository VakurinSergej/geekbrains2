// Даны два числа – показать большее и меньшее число

Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a>b)
{
  Console.Write("большее число: ");
Console.WriteLine(a); 
Console.Write("меньшее число: ");
Console.WriteLine(b); 
}
else 
{
    Console.Write("большее число: ");
Console.WriteLine(b); 
Console.Write("меньшее число: ");
Console.WriteLine(a);  
}

