// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void MultiplicArrays(int [,] array, int [,] arr)
{
    int rowsArray = array.GetLength(0);
    int columnsArray = array.GetLength(1);
    int rowsArr = arr.GetLength(0);
    int columnsArr = arr.GetLength(1);
    if(columnsArray != rowsArr) Console.WriteLine("Перемножение матриц не выполнимо");
    else
    {
        int[,] matrix = new int[rowsArray,columnsArr];
        for(int i=0; i<rowsArray; i++)
        {
            for(int j=0; j<columnsArr; j++)
            {
                int sum = 0;
                for(int k=0; k<columnsArray; k++) sum = sum + array[i,k] * arr[k,j];
                matrix[i,j] = sum;
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Первая матрица:");
int[,] array = {{2,4},{3,2}};
PrintArray(array);
Console.WriteLine("Вторая матрица:");
int[,] arr = {{3,4},{3,3}};
PrintArray(arr);
Console.WriteLine("Результирующая матрица:");
MultiplicArrays(array, arr);
