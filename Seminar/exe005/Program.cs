Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 & number % 23 ==0)
    {
        Console.WriteLine("Кратно 7 и 23");
    }
    else {
        Console.WriteLine("Не кратно 7 и 23");
    }