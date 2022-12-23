// Задайте двумерный массив со случайными числами от -10 до 10. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.)

Console.WriteLine("Введите количество строк: ");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = new int[lines, columns];

int sum = 0;

// Заполнение двумерного массива:
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 11);
    }
}
// Вывод двумерного массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}



// Вариант 1
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == j) {
//             sum = sum + array[i, j];
//         }
//     }
// }

// Вариант 2

int minLength = array.GetLength(0); // 4
if (array.GetLength(1) < minLength)
{
    minLength = array.GetLength(1);
}

for (int i = 0; i < minLength; i++)
{
    sum = sum + array[i, i];
}

Console.WriteLine($"Сумма элементов главной диагонали: {sum}");

