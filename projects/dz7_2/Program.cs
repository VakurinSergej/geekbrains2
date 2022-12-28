// Напишите программу, которая на вход принимает число, 
// и возвращает индексы числа в двумерном массиве или же указание, 
// что такого элемента нет.


// вариант 1 - мой

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
            matr[i,j] = new Random().Next(1,100);
        }
    }
}

int [, ] matrix = new int [5, 5];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("Введите число: ");
int findNumber = int.Parse(Console.ReadLine());





for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j] == findNumber)
        {
            Console.WriteLine("число в ячейке: " + i + "," + j);
        }
        else
        {
            Console.WriteLine("Ваше число отсутствует в массиве");
        }
    }
}




// вариант2


// int[,] FillMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[, ] matrix = new int[3, 4];
// matrix = FillMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("\n Введите число: ");
// int number = int.Parse(Console.ReadLine());
// bool IsNumberInMatrix = false;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (matrix[i, j] == number)
//         {
//             IsNumberInMatrix = true;
//             Console.Write("Число стоит на месте с индексом: " + Convert.ToInt32(i) + ", ");
//             // Console.Write(Convert.ToInt32(i) + ", ");
//             Console.WriteLine(Convert.ToInt32(j));
//         }
//     }
// }

// if (IsNumberInMatrix)
// {
//     Console.WriteLine($"Число {number} есть в массиве");
// }
// else
// {
//     Console.WriteLine($"Числа {number} нет в массиве");
// }

