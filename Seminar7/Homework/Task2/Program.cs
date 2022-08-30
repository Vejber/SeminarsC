// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет 

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
            matr[i, j] = new Random().Next(-10, 10);
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

void FindPosition(int[,] array)
{
    int m = Prompt("Enter row - 1 > ");
    int n = Prompt("Enter column - 1 > ");
    if (m >= 0 && n >= 0)
    {
        int i = array.GetLength(0) - 1;
        int j = array.GetLength(1) - 1;
        if (m > i || n > j)
        {
            Console.WriteLine("There is no such position in the array.");
        }
        else
        {
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if (array[m, n] == array[i, j])
                    {
                        Console.WriteLine($"{array[i, j]}");
                    }
                }
            }
        }

    }
    else
    {
        Console.WriteLine("The number of a row and the number of a column must not be negative.");
    }
}



int m = Prompt("Enter the number of rows in a table > ");
int n = Prompt("Enter the number of columns in a table > ");
if (m > 0 && n > 0)
{
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
    FindPosition(matrix);
}
else
{
    Console.WriteLine("The number of rows and columns must be above zero");
}