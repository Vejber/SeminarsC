// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Prompt("Enter a number > ");
        index++;
    }
}

void PrintArray(int[] col)
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

int AboveZero(int[] col) // считает элементы массива больше 0
{
    int index = 0;
    int length = col.Length;
    int count = 0;
    for (index = 0; index < length; index++)
    {
        if (col[index] > 0)
        {
            count++;
        }
    }
    return count;
}

int M = Prompt("How many numbers are you going to enter? > ");
int[] array = new int[M];
FillArray(array);
PrintArray(array);
int CountPositive = AboveZero(array);
Console.WriteLine($" -> {CountPositive}");
