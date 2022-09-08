// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите количество Строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество Столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.Write("Введите значение: ");
int search = Convert.ToInt32(Console.ReadLine());

if(SearchNum(array,search))
{
    Console.WriteLine("Значение найдено");
}
else
{
    Console.WriteLine("Значение не найдено");
}
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

bool SearchNum(int[,] array, int el)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int ia=0; ia< array.GetLength(1); ia++)
                {
                    if (array[i, ia]==el) return true;;
                }
            
        }
        return false;
}