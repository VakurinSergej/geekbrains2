﻿// Просим найти позицию элемента в массиве с использованием 2-х методов: 
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

int IndexOf(int[] collection, int find) // используем массив collection и элемент поиска find
{
    int count = collection.Length;
    int index = 0;
    int position = 0; // сюда будут записываться позиции числа find
    // если int position = -1 - то оно будет показывать то, 
    // что число которое мы ищем в массиве отсутсвует в нем 
    while (index < count)
    {
        if (collection[index] == find)
        {
         position = index;
        // break; // если хотим найти только первую позицию, а не все
        }
        index++;
    }
    return position;

}

int[] array = new int [10]; // новый массив с 10 элементами
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4); // 4 - число, позицию которого ищем
Console.WriteLine(pos);
