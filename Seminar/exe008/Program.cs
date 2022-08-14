// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними
// в 2D пространстве.
Console.Clear();

//Функция
double dlina(int a, int b, int c, int d)
{
    double l = Math.Sqrt((a-c)*(a-c)+(b-d)*(b-d));
    return l;
}

//Ввод данных
Console.Write("Введите координату X первой точки: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int Yb = Convert.ToInt32(Console.ReadLine());

double AB = dlina(Xa, Ya, Xb, Yb);
Console.WriteLine($"Расстояние между точками {AB}");
