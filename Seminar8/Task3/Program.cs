// Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
//Значения элементов массива 0..9

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
            matr[i, j] = new Random().Next(0, 10);
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

int[] HowMany(int[,] arr)
{
    int[] answer = new int[10];// [0, 1, 0, 0, 0, 2, 0, 1, 1, 0]
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            answer[arr[i, j]]++; //answer[8] = increase by 1; answer[1]++; answer[7]++; answer[5]++; answer[5]++
        }
    }
    return answer;
}

void PrintArr(int[] arr)
{
    int count = 0;
    int length = arr.Length;
    int i = 0;
    while (i < length)
    {
        Console.WriteLine($"{i} - {arr[i]}");
        i++;
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
    int[] result = HowMany(matrix);
    PrintArr(result);
}
else
{
    Console.WriteLine("The number of rows and columns must be above zero");
}

