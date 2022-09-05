// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    if ((m > 0) && (n == 0))
    { 
        return Akkerman(m - 1, 1);
    }
    else
    { 
        return Akkerman(m - 1, Akkerman(m, n - 1)); 
    }
}

int M = Prompt("Enter M > ");
int N = Prompt("Enter N > ");
if (M > 0 && N > 0)
{
    int akkerman = Akkerman(M, N);
    Console.WriteLine(akkerman);
}
else
{
    Console.WriteLine("Numbers must be above zero.");
}
