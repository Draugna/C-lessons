// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел 
// в массиве.

Console.Clear();

void Massive(int[] ar)
{
    int length = ar.Length;
    for(int i = 0; i < length; i++)
    {
        ar[i] = new Random().Next(100 , 1000);
        Console.Write($"{ar[i]} ");
    }
}
int[] array = new int[8];
Massive(array);

int a = 0;
int index = 0;
do
{
    if (array[index] % 2 != 0)
    {
        a++;
        index++;
    }
    else
    {
        index++;
    }
}while ( index < array.Length);

Console.WriteLine();
Console.WriteLine($"Количество четных чисел в масиве: {a}");