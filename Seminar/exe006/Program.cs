// Генерируется случайное целое число n в интервале [ 20 – 99 ].
// Проверяется, делится ли оно на введенное с клавиатуры целое число d
Console.Clear();
int n = new Random().Next(20,100);
 Console.WriteLine(n);
int d =Convert.ToInt32(Console.ReadLine());

if (n % d == 0)
    {
        Console.WriteLine("Делится без остатка");
    }
    else{
        Console.WriteLine("Не делится без остатка");
     }