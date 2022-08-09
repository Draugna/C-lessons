//Генерируются два случайных целых числа a и b в интервале [10 – 30].
//Если a > b, выводится их разность, eсли a < b, выводится сумма,
//eсли a == b, выводится сообщение “числа равны”.
Console.Clear();
int a = new Random().Next(10,31);
Console.WriteLine(a);
int b = new Random().Next(10,31);
Console.WriteLine(b);

if (a>b)
    {
        Console.WriteLine($"Разность чисел равна {a-b}");
    }
    else if (a<b)
    {
        Console.WriteLine($"Сумма чисел равна {a+b}");
    }
    else 
    {
        Console.WriteLine("Числа равны");
    }
