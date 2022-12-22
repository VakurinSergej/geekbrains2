// Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите суммы отрицательных и положительных элементов массива

// Вариант 1

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(-9, 9);
//         index++;
//     }
// }

// void PrintArray(int[] coll)
// {
//     int count = coll.Length;
//     int pos = 0;
//     while (pos < count)
//     {
//         Console.Write(coll[pos] + " ");
//         pos++;
//     }

// }
// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine(" ");

// int sumPolozj = 0;
// int sumOtriz = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         sumPolozj = sumPolozj + array[i];
//     }
//     if (array[i] < 0)
//     {
//         sumOtriz = sumOtriz + array[i];
//     }
// }
// Console.WriteLine($"Сумма положительных цифр равна {sumPolozj}, а сумма отрицательных {sumOtriz}");

// Вариант 2

void ArrayPrint (int[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
Console.WriteLine($"{a[a.Length-1]}]");
}
int[] Array =new int[10];
int sumplus =0;
int summinus =0;

for (int i=0; i<Array.Length; i++) Array[i] = new Random().Next(-9,10);
ArrayPrint(Array);
for (int i=0; i<Array.Length; i++)
{
    if (Array[i]>0) sumplus += Array[i]; 
    else summinus += Array[i]; 

}

Console.Write($"Сумма положительных элементов:{sumplus} Сумма отрицательных элементов:{summinus} ");
Console.WriteLine();


