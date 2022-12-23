// Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы одномерного массива задаются случайно и лежат в промежутке от -10 до 10


void ArrayPrint (int[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
Console.WriteLine($"{a[a.Length-1]}]");
}
int length = new Random().Next(3,11);
int[] Array =new int[length];
int count = 0;
int sum = 0;


for (int i=0; i<length; i++) 
{
Array[i] = new Random().Next(-10,11);
}
ArrayPrint(Array);

for (int i=0; i<length; i++) 
{
    if (Array[i]>0)
    {
       count +=1;
       sum += Array[i];
    }
}
Console.Write("Сумма положительных элементов: " + Convert.ToDouble(sum)/count);
