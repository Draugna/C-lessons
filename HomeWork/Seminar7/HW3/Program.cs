// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Введите количество Строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColumns=GetResultArray(array);
Console.WriteLine($"Среднее арифмитическое каждого столбца = {String.Join("; ",averageColumns)}");

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
double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for(int i=0; i< array.GetLength(1); i++)
        {
            double sum = 0;
            for(int j=0; j < array.GetLength(0); j++)
                {
                    sum+=array[j,i];
                }
            result[i]=Math.Round(sum/array.GetLength(0),2);
        }
        return result;
}