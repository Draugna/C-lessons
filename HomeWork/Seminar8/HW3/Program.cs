// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

Console.Clear();

Console.Write("Введите количество Строк 1 массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Столбцов 1 массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Строк 2 массива: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Столбцов 2 массива: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
if (columns != rowsA)
{
    Console.WriteLine("Матрицы нельзя умножить!");
    return;
}

int[,] array = GetArray(rows, columns, 0, 10);
int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(arrayA);
Console.WriteLine();
PrintArray(MatrixMultiply(array,arrayA));

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

int[,] MatrixMultiply(int[,] array, int [,] arrayA)
{
    int[,] arrayB = new int[array.GetLength(0),arrayA.GetLength(1)];
    for(int i=0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j < arrayA.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1); k++)
            {
                arrayB[i,j] += array[i,k] * arrayA[k,j];
            }
        }
    }
    return arrayB;
}
