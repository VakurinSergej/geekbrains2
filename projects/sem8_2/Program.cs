// Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент


//// Вариант 1

// int m = new Random().Next(3,7);
// int n = new Random().Next(3,7);
// int rowMin = 0;
// int columnMin = 0;
// int min = 10;
// int[,] arr = new int[n,m]; // [количество строк, количество столбцов]
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++) 
//     {
//         arr[i, j] = new Random().Next(0,10); 
//         if (arr[i,j]<min) 
//         {
//             min = arr[i,j];
//             rowMin = i;
//             columnMin = j;
//         }
//     }
// }
// от Александр Дармодехин для Все (21:38)
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// Console.WriteLine($"{min} + {rowMin} + {columnMin}");
// Console.WriteLine();
// int[,] arr2 = new int[n,m];
// for (int i = 0; i < arr2.GetLength(0); i++)
// {
//     for (int j = 0; j < arr2.GetLength(1); j++)
//     {
//         if (i!=rowMin && j!=columnMin) arr2[i,j] = arr[i,j];
//         else arr2[i,j] = 17;
//         // if (i>rowMin && j>columnMin) arr2[i-1,j-1] = arr[i,j];
//         if (arr2[i,j] != 17) Console.Write(arr2[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();


//// Вариант 2 - от Кости


int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetIndexMinEl(int[,] inArray)
{
    int[] result = new int[]{0,0};
    int min=inArray[0,0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(min>inArray[i,j])
            {
                min=inArray[i,j];
                result[0]=i;
                result[1]=j;
            }
        }
    }
    return result;
}
int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] indexes = GetIndexMinEl(array);
Console.WriteLine($"Минимальный элемент находится -> i: {indexes[0]}, j: {indexes[1]}" );
Console.WriteLine();
int[,] resultArray = GetResultArray(array, indexes);
PrintArray(resultArray);
