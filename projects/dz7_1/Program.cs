// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами от -10,0 до 10,0.

Console.WriteLine("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());

double [,] matrix = new double [m, n];

void FillArray (double[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            double number = new Random().Next(-10, 10) + new Random().NextDouble();
            number = Math.Round (number, 3);
            matr[i,j] = number;

        }
    }
}

void PrintArray (double[,] matr)
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

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);




