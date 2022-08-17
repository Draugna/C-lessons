//  Напишите программу, которая принимает на вход число и выдаёт 
//  сумму цифр в числе.

Console.Clear();

void SumOfNumber (int a)
{
    int sum = 0;
    int b = a;
    for (sum = 0; b > 0; b /= 10)
    {
        sum = sum + b%10;
    }

    Console.Write($"Сумма чисел числа {a} равна: {sum}");
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

SumOfNumber(num);