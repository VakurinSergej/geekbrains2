// Программа, которая задаёт массив из 8 случайных чисел (-10, 10) 
// и выводит их на экран




int[] Array =new int[8];
for (int i=0; i<Array.Length; i++) 
{
    
Array[i] = new Random().Next(-10,9);
Console.WriteLine(Array[i]);

}
