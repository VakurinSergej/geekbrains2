// Сформируйте трёхмерный массив из двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


///////// Создание, заполнение и вывод трехмерного массива

// void PrintArray (int[,,]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             for (int k=0; k<matr.GetLength(2); k++)
//             {
//                 Console.Write($"{matr[i, j, k]} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray (int[,,]matr)
// {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//            for (int k=0; k<matr.GetLength(2); k++)
//            {
//                 matr[i,j,k] = new Random().Next(0,10);
//            } 
//         }
//     }
// }


// int [,,] array3d = new int [2,2,2];
// for (int i = 0; i < array3d.GetLength(0); i++)
// {
//     for (int j = 0; j < array3d.GetLength(1); j++)
//     {
//         for (int k = 0; k < array3d.GetLength(2); k++)
//         {
//             Console.Write($"{array3d[i, j, k]} ");

//         }
//     }
//     Console.WriteLine();
// }
    

// FillArray(array3d);
// Console.WriteLine();
// PrintArray(array3d);
// Console.WriteLine();




// Решение задачи

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {   
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
