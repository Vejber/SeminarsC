// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}
void PrintArr(int[] arr)
{
    int count = 0;
    int length = arr.Length;
    int i = 0;
    while (i < length)
    {
        Console.WriteLine($"{arr[i]}");
        i++;
    }
}

int[] RowSum(int[,] arr)
{
    int[] Sums = new int[arr.GetLength(0)];
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Sums[i] = arr[i, j] + Sums[i];
            }

        }
        PrintArr(Sums);

    }
    else
    {
        Console.WriteLine("The number of rows and columns should not be equal.");
    }
    return Sums;
}

int MinInArray(int[] arr)
{
    int min = arr[0];
    int index_min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index_min = i + 1; // for user
        }
    }
    return index_min;
}


int m = Prompt("Enter the number of rows in a table > ");
int n = Prompt("Enter the number of columns in a table > ");
if (m > 0 && n > 0)
{
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    int[] sumsOfRows = RowSum(matrix);
    int minRow = MinInArray(sumsOfRows);
    Console.WriteLine($"The row with the least total of all elements is {minRow}");
}
else
{
    Console.WriteLine("The number of rows and columns must be above zero");
}
