// Двумерный массив в форме матрицы и 2 метода


// Метод вывода матрицы на экран в консоль
void PrintArray (int[,]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}");
        }
        Console.WriteLine();
    }
}

// Метод заполнения матрицы
void FillArray (int[,]matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}


int [,] matrix = new int [3,4]; 
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
