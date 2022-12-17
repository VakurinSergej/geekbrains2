// По заданному номеру дня недели вывести его название

Console.Write("Введите число от 1 до 7: ");
string num = Console.ReadLine();

if (num == "1")
{
    Console.WriteLine("Сегодня ПОНЕДЕЛЬНИК");
}
if(num == "2")
{
    Console.WriteLine("Сегодня ВТОРНИК");
}
if(num == "3")
{
    Console.WriteLine("Сегодня СРЕДА");
}
if(num == "4")
{
    Console.WriteLine("Сегодня ЧЕТВЕРГ");
}
if(num == "5")
{
    Console.WriteLine("Сегодня ПЯТНИЦА");
}
if(num == "6")
{
    Console.WriteLine("Сегодня СУББОТА");
}
if(num == "7")
{
    Console.WriteLine("Сегодня ВОСКРЕСЕНЬЕ");
}