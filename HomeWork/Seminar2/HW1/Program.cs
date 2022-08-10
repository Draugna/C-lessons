// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

Console.Clear();
 //Метод выбора только трехзначного числа с повторением ввода
int num = -1;
do
{
    Console.Write("Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
} while (num < 99 ^ num > 1000);

int two = num/10;
int secondchar = two%10;


Console.WriteLine(num);
Console.WriteLine($"Вторая цифра из числа {num} является: {secondchar}");


