int number1 = new Random().Next(10, 100);
Console.WriteLine(number1);

if (number1/10>number1%10)
{
    Console.WriteLine(number1/10);
}
else
{
    Console.WriteLine(number1%10);
}