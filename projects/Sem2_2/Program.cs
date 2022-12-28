// Программа, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23


// Вариант 1
// Console.WriteLine("Введите число: ");
// var entNumber = Convert.ToInt32(Console.ReadLine());
// var firstPer = 7;
// var secondPer = 23;
// if (entNumber % firstPer == 0 && entNumber % secondPer == 0)
// {
//     Console.Write("Введенное число кратно числам: ");
//     Console.WriteLine(firstPer);
//     Console.Write(" и ");
//     Console.WriteLine(secondPer);
// }
// else
// {
//    Console.WriteLine("Введенное число не кратно заданным числам.");
// } 


// Вариант 2
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if ( a%7 == 0 && a%23 == 0 )
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23");
}
