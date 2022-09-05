// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

void ShowTillN(int n, int m)
{
    if(m > n)
    {
        return;
    }
    if(n % 2 == 0)
    {
    Console.WriteLine(n);
    }
    ShowTillN(n-1, m);
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
