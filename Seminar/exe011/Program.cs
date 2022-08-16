Console.Clear();
void Number(int x)
{
    int i = 0;
    while(x != 0)
    {
        x /= 10;
        i++;
    }
    Console.WriteLine($"Введенное число имеет {i} знака");
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Number(a);