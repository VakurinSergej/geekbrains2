// Программа, которая принимает на вход число и выдаёт сумму цифр в числе

// мое решение - не корректное
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int sum = 0;

// for (int i = 0; i <number.Length; i++) 
// {
//      sum = sum + Convert.ToInt32(number[i]);
// }
// Console.WriteLine(sum);





Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int sum = 0;

for (int i = 0; i < str.Length; i++)
{
    char currentChar = str[i]; // '1'
    // для примера пытаемся получить число сразу из символа
    int positionOfChar = Convert.ToInt32(currentChar); // 49 - порядковый номер '1' в таблице ascii
    // символ currentChar приводим к строке (меняем тип данных на string)
    string stringChar = currentChar.ToString(); // "1" можно убрать эту строку из кода
    int numberFromChar = int.Parse(stringChar); // число 1
    // Console.Write($"Сивол: {currentChar}, позиция: {positionOfChar}, число: {numberFromChar} \n");
}

for (int i = 0; i < str.Length; i++)
{
    int currentNumber = int.Parse(str[i].ToString());
    sum += currentNumber; // sum = sum + currentNumber
}
Console.WriteLine(sum);



