// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива


// void PrintArray (int[,] matr)
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

// void FillArray (int[,] matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(0,11);
//         }
//     }
// }

// void SelectionSort(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         for (int j = 0; j < matr.GetLength(0); j++)
//         {
//             int minPositionI = 0;
//             for (int k = j+1; k < matr.GetLength(0); k++) 
//             {
//                 if (matr[k] < matr[minPositionI])
//                 minPositionI = k;
//             }
//             int temporary = matr[i];
//             matr[i] = matr[minPositionI];
//             matr[minPositionI] = temporary;
//         }
//     }
// }

// int [,] matrix = new int [5, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.Write();
// // SelectionSort(matrix);
// PrintArray(matrix);





void PrintArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,100);
        }
    }
}

void SelectionSort(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0)-1; j++)
        {
            int minPositionI = 0;
            for (int k = j+1; k < matr.GetLength(0); k++) 
            {
                if (matr[k,j] < matr[minPositionI,j])
                minPositionI = k;
            }
            int temporary = matr[i,j];
            matr[i,j] = matr[minPositionI,j];
            matr[minPositionI,j] = temporary;
        }
    }
}



int [, ] matrix = new int [5, 5];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
SelectionSort(matrix);
Console.WriteLine();
PrintArray(matrix);


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++);
// }

