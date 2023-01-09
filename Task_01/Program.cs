// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateArray(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] array = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            array[i,j] = new Random().Next(minNumber, maxNumber+1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[,] SortingRows(int[,] array)
{
    int rows =array.GetLength(0);
    int columns =array.GetLength(1);
    int temp = 0;
    for(int i=0; i<rows; i++)
    {
        for(int countSort=0; countSort<columns-1; countSort++)
        {
            for(int j=0; j<(columns-1-countSort); j++)
            {
                if(array[i,j]>array[i,j+1])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }
        }
    }
    return array;
}

int[,] array = CreateArray(4, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] arr = SortingRows(array);
PrintArray(arr);