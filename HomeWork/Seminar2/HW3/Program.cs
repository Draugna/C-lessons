// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет,
// является ли этот день выходным.
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int week = 7;
int Day = num;

if (num > 8)
{
do
{
    num = num - week;
}
while (num > 8);
}
else
{
    
}
if( num == 6 ^ num == 7)
        {
            Console.WriteLine($"Заданное число {Day} - Выходной!");
        }
    else
        {
            Console.WriteLine($"Заданное число {Day} -  Будний день!");
        }
Console.Write($"Это {num} день недели!");

