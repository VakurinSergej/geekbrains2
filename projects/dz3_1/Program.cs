// программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом
// (читается слева направо и справа налево одинаково)

Console.WriteLine("Введите число: ");
string number = int.Parse(Console.ReadLine());
for (i=0; i < number.Length; i++;)
{
if (number[i] == number[number.Length])
    (i++, number.Length--);
    Console.WriteLine("это число полиндронно");
//else
  //  Console.WriteLine("это число НЕ полиндронно");
}
