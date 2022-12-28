// Поиск позиции (индекса) нужного элемента в массиве


int [] array = {1, 12, 31, 4, 15, 16, 17, 18, 4};
int n = array.Length;
int find = 4; // число, место которого нужно найти
int index = 0; 
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        // break; // это если нам нужно найти только первый индекс, а не все, где есть 4
    }
    index++;
}

