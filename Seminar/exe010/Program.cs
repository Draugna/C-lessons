//Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

int GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Cумма цифр от 1 до введенного числа: {GetSumNums(num)}");
