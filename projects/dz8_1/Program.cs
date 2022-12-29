// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива


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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1)-1; k++) 
            {
                if (matr[i,k] < matr[i, k + 1])
                {
                    int temporary = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i,k] = temporary;
                }
            }
            
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


