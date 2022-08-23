// Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.

Console.Clear();

void Massive(int[] ar)
{
    int length = ar.Length;
    for(int i = 0; i < length; i++)
    {
        ar[i] = new Random().Next(0 , 1000);
        Console.Write($"{ar[i]} ");
    }
}
int[] array = new int[8];
Massive(array);

int sum = 0;

for (int index = 1; index < array.Length ; index = index + 2)
    {
        sum = sum + array [index];
    }
    
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {sum}");
