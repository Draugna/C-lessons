//Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int sto = number/100;
int dec = number%10;
Console.WriteLine($"{sto}{dec}");

