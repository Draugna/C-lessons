// Генерируются два случайных целых числа c и d в интервале [-10 – 10].
// Если оба числа четные, выводится их частное, если оба нечетные - их сумма,
// если одно число четное, а другое нечетное, выводится их произведение ( if ),

Console.Clear();

int c = new Random().Next(-10, 11);
Console.WriteLine($"Первое число : {c}");
int d = new Random().Next(-10, 11);
Console.WriteLine($"Второе число : {d}");
int total = -1;

if (c % 2 == 0 && d % 2 == 0)
    {
        total = c / d;
        Console.WriteLine($"Деление : {total}");
    }
    else if ( c % 2 != 0 ^ d % 2 != 0)
    {
        total = c + d;
        Console.Write($"Сложение : {total}");
    }
    else 
    {
        total = c * d;
        Console.Write($"Умножение : {total}");
    }