// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    double number = new Random().Next(0, 10) + new Random().NextDouble(); 
    array[i] = Math.Round(number, 2); 
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

double min = array[0];
double max = array[0];


for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
        {
            max = array[i];
        }
if (array[i] < min)
        {
            min = array[i];
        }

}

Console.WriteLine($"Максимальное значение: {max}, минимальное значение: {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {max - min}");






