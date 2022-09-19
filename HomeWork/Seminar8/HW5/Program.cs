// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

Console.Write("Введите размер матрицы: ");
int s = int.Parse(Console.ReadLine());
int[,] arr = GetArray(s);
PrintArray(arr);

int[,] GetArray(int size)
{
    int[,] result = new int[size,size];
    int i = 0;
    int j = 0;
    int rowE = size-1;
    int columnE = size-1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while(count < size * size)
    {
        count++;
        result[i,j] = count;

        if(left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top =true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        
    

        if(!left && top)
        {
            if(i==rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }

        if(!left && !top)
        {
            if(j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else{
                j--;
                continue;
            }
        }

        if (left && !top)
        {
            if(i == rowS)
            {
            columnS++;
            top=true;
            left= true;
            j++;
            continue;
            }
            else
            {
            i--;
            continue;
            }
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int ia=0; ia<inArray.GetLength(1); ia++)
        {
            Console.Write($"{inArray[i,ia]} ");
        }
        Console.WriteLine();
    }
}
