// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int Min(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
            }
        }
    }
    return min;
}

void DeleteRowColumn(int min, int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == min)
            {
                for (int l = 0; l < arr.GetLength(0); l++)
                {
                    for (int k = 0; k < arr.GetLength(1); k++)
                    {
                        if (l != i && k != j)
                        {
                            Console.Write($"{arr[l, k]} ");
                        }
                    }
                    Console.WriteLine();
                }
                return;
            }
        }
    }
}


int m = Prompt("Enter the number of rows in a table > ");
int n = Prompt("Enter the number of columns in a table > ");
if (m > 0 && n > 0)
{
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    int min = Min(matrix);
    Console.Write(min);
    Console.WriteLine();
    DeleteRowColumn(min, matrix);
}
else
{
    Console.WriteLine("The number of rows and columns must be above zero");
}
