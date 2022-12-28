// Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).




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
            matr[i,j] = new Random().Next(0,11);
        }
    }
}

int [, ] matrix = new int [5, 2];
int [, ] matrix2 = new int [5, 2];
int [, ] matrix3 = new int [5, 2];


FillArray(matrix);
FillArray(matrix2);
Console.WriteLine();
PrintArray(matrix);
PrintArray(matrix2);


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        {
            int[,] matrix3 = matrix[i,j] * matrix2[i,j];
            Console.WriteLine(matrix3);
        }
    }
}

