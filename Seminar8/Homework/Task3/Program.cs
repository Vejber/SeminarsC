// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    Console.WriteLine();
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

int[,] MatrixMultiply(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                result[i, j] = (arr1[i, k] * arr2[k, j]);
            }
        }

    }
    return result;
}

int i = Prompt("Enter the number of rows in table X > ");
int j = Prompt("Enter the number of columns in table X > ");
Console.WriteLine("Number of columns in table X must be equal to number of rows in table Y.");
int m = Prompt("Enter the number of rows in table Y > ");
int n = Prompt("Enter the number of columns in table Y > ");
if (m > 0 && n > 0 && i > 0 && j > 0 && j == m)
{
    int[,] matrix1 = new int[i, j];
    int[,] matrix2 = new int[m, n];
    FillArray(matrix1);
    FillArray(matrix2);
    PrintArray(matrix1);
    PrintArray(matrix2);
    int[,] matrix12 = MatrixMultiply(matrix1, matrix2);
    PrintArray(matrix12);
}
else
{
    Console.WriteLine("The number of rows and columns in both tables must be above zero AND number of columns in table X must be equal to number of rows in table Y.");
}

