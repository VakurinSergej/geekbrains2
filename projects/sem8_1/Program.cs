// Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент


                    // Вариант 1

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// меняем местами первую и последнюю строку
for (int i = 0; i < matrix.GetLength(1); i++)
{
   int temp = matrix[0, i];
   matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
   matrix[matrix.GetLength(0) - 1, i] = temp;
}

// меняем местами первый и последний столб 
//for (int j = 0; j < matrix.GetLength(0); j++)
//{
//    int temp = matrix[j, 0];
//    matrix[j, 0] = matrix[j, matrix.GetLength(1) - 1];
//    matrix[j, matrix.GetLength(1) - 1] = temp;
//}
Console.WriteLine();
PrintArray(matrix);


                        // вариант 2

// int[,] array = new int[3,4];
// for (int i =0; i <array.GetLength(0); i++)
// {
//     for(int j =0; j <array.GetLength(1); j++)
//     {
//     array [i,j] = new Random().Next(0, 10);
//      Console.Write(array[i,j] + ", ");
//     }
//      Console.WriteLine();
// }
// Console.WriteLine();

// for (int i =0; i <array.GetLength(0); i++) 
// {
//     for(int j =0; j <array.GetLength(1); j++)
    
//     {
//         if (i==0) 
//         {
//     Console.Write(array[array.GetLength(0)-1,j] + ", ");
//         }
//        else if (i==array.GetLength(0)-1)
//        {
//     Console.Write(array[0,j] + ", ");
//        }
//     else Console.Write(array[i,j] + ", ");
//     } 
//     Console.WriteLine();
// }






                // незаконченный вариант
// void FillArray (int[, ]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(0,11);
//         }
        
//     }
// }

// void PrintArray (int[, ]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [, ] matrix = new int [4, 4];
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// // int count = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     if (matrix[i] < min)
//     {
//         min = matrix[i];
//     }
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
        
//         if (matrix[j] < min)
//         {
//             min = matrix[j];
//             Console.WriteLine()
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(matrix);
