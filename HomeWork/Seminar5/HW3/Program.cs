// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

Console.Clear();

void Massive(int[] ar)
{
    int length = ar.Length;
    for(int i = 0; i < length; i++)
    {
        ar[i] = new Random().Next(-1000 , 1000);
        Console.Write($"{ar[i]} ");
    }
}
int[] array = new int[8];
Massive(array);

int max = array[0];
int min = array[0];
int index = 0;
do{
if(array[index] > max)
    {
        max = array[index];
    }
else if(array[index] < min) 
{
    min = array[index];
}
else
{

}
index++;
}while(index < array.Length);

Console.WriteLine();

Console.WriteLine($" Минимальное число: {min}");
Console.WriteLine($" Максимальное число: {max}");
int itog = max - min;
Console.WriteLine($" Разность максимального и минимального числа равна: {itog}");
