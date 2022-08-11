// По введенному номеру выводится название дня недели (1 – пн, 2 –вт,...)
// и сообщение “рабочий день” или “выходной” (операторы switch, if).

Console.Clear();
Console.Write("Введите номер дня: ");
int a = Convert.ToInt32(Console.ReadLine());

switch(a)
{
    case 1 : Console.Write("пн"); break;
    case 2 : Console.Write("вт"); break;
    case 3 : Console.Write("ср"); break;
    case 4 : Console.Write("чт"); break;
    case 5 : Console.Write("пт"); break;
    case 6 : Console.Write("сб"); break;
    case 7 : Console.Write("вск"); break;
    default : Console.Write("Такого дня недели нет!"); break;
}
if(a == 6 ^ a == 7)
{
    Console.Write(" - выходной");
}
else
{
    Console.Write(" - рабочий день");
}