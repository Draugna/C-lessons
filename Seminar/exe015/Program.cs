// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.). 

void ReverseArray(int[] arr)
{
    int count = arr.Length;
    int[] result = new int[count];

    for(int i = 0; i < count; i++)
    {
        result[i] = arr[count-1-i];
        Console.Write(result[i]);
    }

}

int[] array = {1,2,3,4,5};
ReverseArray(array);