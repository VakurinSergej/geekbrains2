// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случайно и лежат в промежутке от -10 до 10

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 11);
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
int[] newarray = new int[10];
for (int i = 0; i < array.Length; i++)
{
    newarray[i] = array[array.Length - 1 - i];
     Console.Write(newarray[i] + " ");
}

