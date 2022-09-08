// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
Console.Clear();

Console.Write("Введите количество Строк: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество Столбцов: ");
int rows = int.Parse(Console.ReadLine());

double[,] array = GetArray(columns, rows, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m,n];
    for (int i = 0; i<m; i++)
    {
        for(int ia=0; ia<n; ia++)
        {
            result[i,ia] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int ia=0; ia<inArray.GetLength(1); ia++)
        {
            Console.Write($"{inArray[i,ia]:f1} ");
        }
        Console.WriteLine();
    }
}