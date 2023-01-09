// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumRows(int[,] array)
{
    int minSumRow = 0;
    int minI = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        int sumRow = 0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i,j];
        }
        if(i == 0)
        {
            minSumRow = sumRow;
            minI = i;
        }
        if(sumRow < minSumRow)
        {
            minSumRow = sumRow;
            minI = i;
        }
    // Если необходимо вывести сумму по строкам
    //Console.WriteLine(sumRow);  
    }
    Console.WriteLine("Строка c наименьшей суммой элементов - "+(minI+1));
}

int[,] array = CreateArray(4, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
MinSumRows(array);