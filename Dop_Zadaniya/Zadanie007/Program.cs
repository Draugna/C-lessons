// Выводится название предмета по введенной первой букве: ф - физика, м -
// математика, и - история, г - география, б - биология (оператор switch).
Console.Clear();
Console.Write("Введите первую букву предмета: ");
string? a = Console.ReadLine();

switch(a)
{
    case "ф" : Console.Write("Физика"); break;
    case "м" : Console.Write("Математика"); break;
    case "и" : Console.Write("История"); break;
    case "г" : Console.Write("География"); break;
    case "б" : Console.Write("Биология"); break;
    default : Console.Write("Такого предмета нет"); break;
}