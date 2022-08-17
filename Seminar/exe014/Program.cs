// Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
Console.Clear();

void NewArray(int[] ar)
{
    int length = ar.Length;
    Console.Write("[");
    for(int index = 0; index < length; index++)
    {
        ar[index] = new Random().Next(0,2);
        if (index >= length - 1)
        {
            Console.Write($"{ar[index]}");
        }
        else
        {
        Console.Write($"{ar[index]},");
        }
    }
    Console.Write("]"); 
}
int[] array = new int[8];
NewArray(array);

