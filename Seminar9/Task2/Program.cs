// Задайте значения M и N. 
// Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

void ShowTillN(int n, int m)
{
    if(n == m)
    {
        Console.WriteLine(m);
        return;
    }
    // or
    // if(m > n)
    // {
    //     return;
    // }
    
    ShowTillN(n-1, m);
    Console.WriteLine(n);
    
}

int N = Prompt("Enter number1 > ");
int M = Prompt("Enter number2 > ");
if(M < N)
{
ShowTillN(N, M);
}
else
{
    Console.WriteLine("Number2 should be smaller than number1.");
}