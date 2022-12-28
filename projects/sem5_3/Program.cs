// Задайте массив из 8 случайных чисел из промежутка [-9, 9]. 
// Напишите программу получает на вход число и определяет, 
// присутствует ли заданное число в массиве.


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 9);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }

}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

Console.WriteLine("Введите число: ");
int zChislo = Convert.ToInt32(Console.ReadLine());
int chisloEst = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == zChislo)
    {
        chisloEst++;
    }
}
if (chisloEst > 0)
{
    Console.WriteLine($"Заданное число присутствует в массиве в количестве {chisloEst}.");
}
else
{
    Console.WriteLine("Заданного числа в массиве нет.");
}


