// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

int SumFromNToM(int n, int m)
{
    if(m > n)
    {
        return 0;
    }
    
    return SumFromNToM(n, m + 1) + m;
}

int N = Prompt("Enter number1 > ");
int M = Prompt("Enter number2 > ");
if(M < N)
{
int sum = SumFromNToM(N, M);
Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Number2 should be smaller than number1.");
}
