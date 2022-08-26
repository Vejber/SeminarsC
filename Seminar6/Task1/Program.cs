// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) //void значит не возвращает значения
{
    int length = col.Length;
    int index = 0;
    Console.Write("["); // для красивого вывода
    while (index < length - 1)
    {
        Console.Write($"{col[index]}, "); //для красивого вывода
        index++;
    }
    Console.Write($"{col[length - 1]}");
    Console.Write("]"); // для красивого вывода
}

int[] ReverseArray(int[] arr)
{
    int index = 0;
    int length = arr.Length;
    for (index = 0; index < length / 2 + length % 2; index++)
    {
        int temp = arr[index];
        arr[index] = arr[length - 1 - index];
        arr[length - 1 - index] = temp;
    }
    return arr;
    PrintArray(arr);
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
ReverseArray(array);
PrintArray(array);

