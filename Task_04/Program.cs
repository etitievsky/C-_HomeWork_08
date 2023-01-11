// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] CreateArray(int rows, int columns, int width, int minNumber, int maxNumber)
{
    int[,,] array = new int[rows, columns, width];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            for(int k=0; k<width; k++)
            {
                int temp = new Random().Next(minNumber, maxNumber+1);
                bool contains = CheckArray(array, temp);
                if(contains) k--;
                else array[i,j,k] = temp;
            }
        }
    }
    return array;
}

bool CheckArray(int[,,]array, int temp)
{
    bool contains= false;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                if(temp == array[i,j,k])
                {
                    contains = true;
                    break;
                }
            }
        }
    }
    return contains;
}

void PrintArray(int[,,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = CreateArray(2, 2, 2, 10, 99);
PrintArray(array);