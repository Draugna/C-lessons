// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество Строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

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


int GetRowNumber (int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       minsum = minsum + array[0,i];
    }
    for (int i = 1; i < array.GetLength(0); i++)   
    {   
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum+array[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}