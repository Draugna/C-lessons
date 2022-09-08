// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно 
// палиндромом.

Console.Clear();

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int c = 0;
int d = 0;

do
{
    d = b % 10;
    b = b / 10;
    c = c * 10 + d;
Console.WriteLine(c);
} while (c < a);

 
 if (c == a)
 {
    Console.Write($"Число {a} - Палиндром");
 }
else
{
    Console.Write($"Число {a} - Не Палиндром");
}