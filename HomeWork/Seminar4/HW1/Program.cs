// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Clear();

void Multiply (int z, int x)
{
    int sqr = 1;
    for (int i = 0; i<x; i++)
    {
        sqr *= z;
    }
    Console.WriteLine($"Число {z} в степени {x} равно: {sqr}");
}


Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

Multiply(A,B);