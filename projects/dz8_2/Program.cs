// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 100);
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

int[,] matrix = new int[5, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

int minSumRows = 0;

for (int i = 0; i < matrix.GetLength(1); i++) // столбцы
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(0); j++) // строчки
        {
            sum = sum + matrix [j,i];
            Console.WriteLine($" Сумма строки {sum}");
            
            // int min = sum(matrix[j,i]);
            // if (int sum(matrix[j,i]) < min)
        }
        


            // if (matrix[j,i] < min)
            //{
            //    min = matrix[j,i];
            // }
        
    }

PrintArray(matrix);


