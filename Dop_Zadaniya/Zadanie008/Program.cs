// Выводится название страны и ее столицы по введенной первой букве:
// б – Беларусь, Минск, р – Россия, Москва, л –Литва, Вильнюс (switch),

Console.Clear();
Console.Write("Введите первую букву Страны: ");
string a = Console.ReadLine();

switch(a)
{
    case "б" : Console.Write("Беларусь, Минск"); break;
    case "р" : Console.Write("Россия, Москва"); break;
    case "л" : Console.Write("Литва, Вильнюс"); break;
    default : Console.Write("Такой страны нет!"); break;
}