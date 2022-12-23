// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 11);
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

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

// //////// это сумма нечетных элементов
// int sum = 0;

// for (int i=0; i<array.Length; i++)
// {
//     if (!(array[i] % 2 == 0)) 
//     {
//         sum = sum + array[i];
//     }
// }
//  Console.WriteLine("Сумма нечетных чисел: " + sum);

int sum = 0;

for (int i=0; i<array.Length; i++)
{    
     if (!(i % 2 == 0)) 
     {
        sum = sum + array[i];
     } 
}
 Console.WriteLine("Сумма чисел нечетных позиций: " + sum);


