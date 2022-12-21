// Просим показать все элементы массива по порядку
// для этого создает 2 метода: 
// 1) заполнения массива случайными числами и 
// 2) печать массива в консоль

// метод 1 - заполняет массив случайными числами
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10); // заполняет случайными числами от 1 до 10
        index++;
    }
}

// метод 2 - выводит на печать

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10]; // новый массив с 10 элементами
FillArray(array);
PrintArray(array);

