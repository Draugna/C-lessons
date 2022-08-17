// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.

Console.Clear();

void Multiply(int a)
{
    int mltp = 1;
    for(int i = 1; i <= a; i++)
    {
        mltp *= i;
    }
    
    
    Console.Write($"Произведение чисел от 1 до {a} равна: {mltp}");
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Multiply(N);