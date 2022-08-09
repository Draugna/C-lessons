// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b)
    {
        Console.Write("Второе число является квадратом первого числа");
    }
else if (b * b == a)
    {
        Console.Write("Первое число является квадратом второго числа");
    }
    else{
        Console.Write("Числа не являются квадратами друг друга");
    }