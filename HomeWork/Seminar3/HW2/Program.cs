// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

Console.Clear();

//Функция
double dlina(int a, int b, int c, int d, int e, int f)
{
    double len = Math.Sqrt((a-c)*(a-c)+(b-d)*(b-d)+(e-f)*(e-f));
    return len;
}

//Ввод данных
Console.Write("Введите координату X первой точки: ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int Zb = Convert.ToInt32(Console.ReadLine());

double AB = dlina(Xa, Ya,Xb, Yb, Za, Zb);
Console.WriteLine($"Расстояние между точками {AB}");
