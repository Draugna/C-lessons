// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.


Console.Clear();

Console.Write("Введите количество Строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int ia=0;ia<n; ia++)
        {
            result[i,ia] = new Random().Next(min, max+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int ia=0; ia<inArray.GetLength(1); ia++)
        {
            Console.Write($"{inArray[i,ia]} ");
        }
        Console.WriteLine();
    }
}

void SortArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int t = j+1; t < array.GetLength(1); t++)
            {
                if(array[i,t] > array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j]=array[i,t];
                    array[i,t] = temp;
                }

            }
        }
    }
}