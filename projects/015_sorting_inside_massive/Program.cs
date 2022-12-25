// Упорядочивание данных внутри массива


int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// 1) вводим метод вывода на экран
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(array);

// 2) вводим метод, который будет упорядочивать массив
void SelectionSort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = 1;
        for (int j=i+1; j<array.Length; j++) // j=i+1 - это отсортированные эл-ты
        {
            if (array[j]<array[minPosition])
            minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);
