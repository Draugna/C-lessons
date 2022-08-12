Console.Clear();

void printQuarter(int a, int b)
{
   if (a>0 && b>0)
   {
    Console.WriteLine("Первая четверть");
   }
   else if (a<0 && b>0)
   {
    Console.WriteLine("Вторая четверть");
   }
   else if (a<0 && b<0)
   {
    Console.WriteLine("Третья четверть");
   }
   else if (a>0 && b<0)
   {
    Console.WriteLine("Четвертая четверть");
   }
   else
   {
    Console.WriteLine("Определить четверть не возможно");
   }
}

Console.Write("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

printQuarter(x,y);