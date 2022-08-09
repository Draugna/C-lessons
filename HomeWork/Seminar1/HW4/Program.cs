Console.Clear();

//Запись числа до которого будем писать все четные/нечестные числа
Console.Write("Вставьте число = ");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number = 0;

// Вывод записи для всех четных чисел
Console.Write("Четные числа до числа " + numberA + " равны: ");

//Логика по выписыванию всех четных/нечотных чисел до заданного числа
while (count <= numberA)
{
    if ((count % 2) == 0)
    {
        number = count;
        Console.Write(number + ", ");
        count++;

    }
    else
    {
        count++;
    }
}

