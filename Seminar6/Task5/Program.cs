// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int[] CopyArray(int[] n)
{
    int[] copyArray = new int[n.Length];
    int index = 0;
    int length = n.Length;
    for (index = 0; index < length; index++)
    {
        copyArray[index] = n[index];
    }
    return copyArray;
}

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

int[] num = new int[10];
FillArray(num);
Console.WriteLine($"{(string.Join(",", num))}");
int[] copy = CopyArray(num);
Console.WriteLine($"{(string.Join(",", copy))}");
// num[1] = 11;
// Console.WriteLine($"{(string.Join(",", num))}");
// copy = CopyArray(num);
// Console.WriteLine($"{(string.Join(",", copy))}");