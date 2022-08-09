Console.Clear();

//Запись числа для проверки на Четное/Нечетное
Console.Write("Вставьте число = ");
int numberA = Convert.ToInt32(Console.ReadLine());
string proverka;
//Логика по Проверке четности/нечотности
 
if( (numberA % 2) == 0)
    {proverka = " Четное";}
    else
    {  
        proverka = " Нечетное";    
     };


    Console.Write("Число " + numberA + proverka);
