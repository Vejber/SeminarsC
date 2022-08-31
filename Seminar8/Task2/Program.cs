// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ExchangeRowForColumn(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }

        }
        PrintArray(arr);

    }
    else
    {
        Console.WriteLine("Changing rows for columns is not possible due to their inequality");
    }
    return arr;
}



int m = Prompt("Enter the number of rows in a table > ");
int n = Prompt("Enter the number of columns in a table > ");
if (m > 0 && n > 0)
{
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    ExchangeRowForColumn(matrix);
}
else
{
    Console.WriteLine("The number of rows and columns must be above zero");
}