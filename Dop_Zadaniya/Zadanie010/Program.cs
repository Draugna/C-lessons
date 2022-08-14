// Проверяется правильность введенного логина строго из 5 букв
// и пароля из 6 и более цифр.
Console.Clear();

// Ввод данных
string? login = "0"; // Задаваемый логин
int password = 0; //Задаваемый пароль
int len = login.Length; // Длина Логина
int length = password;  // Копия пароля для проверки длины
int i = 0;  //счетчик длины

// Проверка на строгость логина (5 символов)
do
{
    Console.Write("Введите Логин: ");
    login = Console.ReadLine();
    len = login!.Length;
} while (len < 5 ^ len > 5);

// Проверка на кол-во сиволов в пароле
do
{
    Console.Write("Введите Пароль из 6 и более цифр: ");
    password = Convert.ToInt32(Console.ReadLine());
    i = 0;
    length = password;
    while (length > 0)
    {
        i++;
        length /= 10;
    }
} while (i < 6);

//Вывод итога
Console.WriteLine($"Ваш Логин: {login}");
Console.WriteLine($"Ваш Пароль: {password}");