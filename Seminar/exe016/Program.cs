// Вычислить среднее арифметическое положительных элементов в 
// одномерном массиве. 

Console.Clear();

void SumElem(int[] arr)
{
    double sum = 0;
    int n = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            sum +=  arr[i];
            n++;
        }
    }
    Console.Write($"{sum/n:f2}");
}


int[] array = {1, -5, 8, 4, -9};
SumElem(array);