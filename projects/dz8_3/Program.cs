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
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

int [, ] matrix1 = new int [2, 2];
int [, ] matrix2 = new int [2, 2];
int [, ] matrix3Result = new int [2, 2];

FillArray(matrix1);
Console.WriteLine();
PrintArray(matrix1);
Console.WriteLine();

FillArray(matrix2);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();


void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3Result)
{
    for (int i = 0; i < matrix3Result.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3Result.GetLength(1); j++)
        {
           int multiply = 0;
           for (int k = 0; k < matrix1.GetLength(1); k++)
           {   
              multiply = matrix1[i,j] * matrix2[i,j];
           }
           matrix3Result[i,j] = multiply;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


MultiplyMatrix(matrix1, matrix2, matrix3Result);
Console.WriteLine($"\nПроизведение первого и второго массива:");
PrintArray(matrix3Result);
