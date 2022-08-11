// По введенному номеру месяца выводится название поры года (зима, весна,
// лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр

Console.Clear();

Console.Write("Введите номер месяца: ");
int a = Convert.ToInt32(Console.ReadLine());
int year = 12;

// Проверяем введено ли число больше, чем месяцев в году.
if (a > 13 )
{
    do
{
    a = a - year;
}while (a > 12);
}
else
{
    do
{
    a = a + year;
}while (a < 0 & a < 12);
}
// Расстановка по месяцам и роду занятий на них
if( a == 1 ^ a == 2 ^ a == 12)
    {
        Console.Write("Зима");
        Console.Write(" - Cессия");
    }
    else if( a == 3 ^ a == 4 ^ a == 5)
        {
            Console.Write("Весна");
            Console.Write(" - 2 семестр");
        }
        else if( a == 6 ^ a == 7 ^ a == 8)
        {
            Console.Write("Лето");
            Console.Write(" - Каникулы!");
        }
        else
        {
            Console.Write("Осень");
            Console.Write(" - 1 семестр");
        }