Console.Clear();

//Перечисление Трех чисел из которых ищется максимальное
Console.Write("Вставьте число a = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вставьте число b = ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вставьте число c = ");
int numberС = Convert.ToInt32(Console.ReadLine());

//Логика по вычислению максимума
int max = numberA;
    while(numberA > max) max = numberA;
    while(numberB > max) max = numberB;
    while(numberС > max) max = numberС;

    Console.Write("Максимальное число равно, " + max);
