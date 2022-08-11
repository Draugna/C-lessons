// Проверяется соответствие веса и роста (ввод рост и вес; вывод одного
// из сообщений "Норма", "Нужно похудеть", "Нужно поправиться".
// Нормальный вес (в кг) = (рост (в см) – 100) ± 10%.
Console.Clear();

Console.Write("Введите свой рост: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите свой вес: ");
int b = Convert.ToInt32(Console.ReadLine());
int norma = (a - 100);
Console.WriteLine(norma);

if ( norma + (norma * 0.1) < b & norma - (norma * 0.1) < b)
    {
        Console.Write("Вам нужно похудеть");
    }
    else if( norma + (norma * 0.1) > b & norma - (norma * 0.1) > b)
    {
        Console.Write("Вам нужно Поправиться");
    }
    else
    { 
        Console.Write("Норма");
    }
