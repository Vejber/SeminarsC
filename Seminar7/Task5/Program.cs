// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]

// Введенный элемент 6, результат: такого элемента нет.

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

void FindNumber(int[,] array)
{
    int num = Prompt("Enter a number > ");
    for (int i = 0; i < array.GetLength(0); i++) //rows
    {
        for (int j = 0; j < array.GetLength(1); j++) // columns
        {
            if (array[i, j] == num)
            {
                Console.WriteLine($"The entered number is {num}, the result is [{i}, {j}].");
                return; //выход из метода после первого попадания на иф
            }
        }
    }
    Console.WriteLine($"There isn't such number as {num} in the array.");
}



int m = Prompt("Enter the number of rows in a table > ");
int n = Prompt("Enter the number of columns in a table > ");
if (m > 0 && n > 0)
{
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    FindNumber(matrix);
}
else
{
    Console.WriteLine("Number of row and columns must be positive.");
}