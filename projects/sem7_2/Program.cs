// Задача 2: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


// вариант 1

void FillArray (int[, ]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
        // Console.WriteLine();
    }
}
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
int [, ] matrix = new int [3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i,j] = matrix[i,j] * matrix[i,j];  
        }
    }
}
Console.WriteLine();
PrintArray(matrix);

// // вариант 2

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//         // Console.WriteLine();
//     }
// }
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             double x = Math.Pow(matrix[i, j], 2); // получение квадрата с типом данных dobule
//             matrix[i, j] = Convert.ToInt32(x); // изменение типа данных с double на int
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(matrix);

