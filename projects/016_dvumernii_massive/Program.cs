// Двумерный массив

// // Массив как сетка строк и столбцов, пустая или заполненная текстом
// string[,] table = new string [2,5]; // [2,5] - 2 строки 5 столбцов
// table[1,2] = "слово"; // в клетке со строкой 1 и столбцом 2 лежит слово
// for (int rows = 0; rows < 2; rows++) // 2 - кол-во строк = length
// {
//     for (int columns = 0; columns < 5; columns++) // 5 = length
//     {
//         Console.WriteLine($"-{table [rows,columns]}-");
//     }
// }

// Массив как числовая сетка
int [,] matrix = new int [3,4]; // 3 - кол-во строк, 4 - кол-во столбцов
for (int rows = 0; rows < 3; rows++) // 3 = matrix.GetLength(0) - 0 - это строки
{
    for (int columns = 0; columns < 4; columns++) // 4 = matrix.GetLength(1) - 1 - это столбцы
    {
        Console.WriteLine($"{matrix[rows,columns]}");
    }
    Console.WriteLine();
}

