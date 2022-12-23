// Задайте массив из 10 случайных чисел из промежутка [-100, 100]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]


void ArrayPrint (int[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
Console.WriteLine($"{a[a.Length-1]}]");
}
int[] Array =new int[10];
int count = 0;

for (int i=0; i<Array.Length; i++) 
{
Array[i] = new Random().Next(-100,101);
}
ArrayPrint(Array);
Console.WriteLine("Найдем количество элементов массива из отрезка [10;99]");

for (int i=0; i<Array.Length; i++)
{
    if (Array[i]>=10&&Array[i]<=99) 
    {count +=1;
    Console.WriteLine(Array[i]);
    }
   
}
 Console.WriteLine("Таких элементов в массиве:" + count);
