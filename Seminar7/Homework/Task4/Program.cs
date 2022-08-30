// Со звездочкой(*). 
// Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)


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

int FindMaxI(int[,] arr)
{
    int sum = 0;
    int maxI = arr[0, 0];
    int i = 0;
    int j = 0;
    for (i = 0; i < arr.GetLength(0); i++)
    {
        j = 0;
        maxI = arr[i, j];
        for (j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > maxI)
            {
                maxI = arr[i, j];
            }
        }
        sum = sum + maxI;
    }
    Console.WriteLine($"The total of the biggest elements in each row is {sum}");
    return sum;
}

int FindMinJ(int[,] arr)
{
    int sum = 0;
    int minJ = arr[0, 0];
    int j = 0;
    int i = 0;
    for (j = 0; j < arr.GetLength(1); j++)
    {
        i = 0;
        minJ = arr[i, j];
        for (i = 0; i < arr.GetLength(0); i++)
        {
            if (arr[i, j] < minJ)
            {
                minJ = arr[i, j];
            }
        }
        sum = sum + minJ;
    }
    Console.WriteLine($"The total of the lowest elements in each column is {sum}");
    return sum;
}

int m = Prompt("Enter the number of rows in a table > ");
int n = Prompt("Enter the number of columns in a table > ");
if (m > 0 && n > 0)
{
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    int sumMaxI = FindMaxI(matrix);
    int sumMinJ = FindMinJ(matrix);

    Console.WriteLine($"{sumMaxI} - {sumMinJ} = {sumMaxI - sumMinJ}");
}
else
{
    Console.WriteLine("Number of rows and columns must be positive.");
}