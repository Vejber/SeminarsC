// адайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

void ShowTillN(int n)
{
    if(n <= 0)
    {
        return;
    }
    ShowTillN(n-1);
    Console.WriteLine(n);
}

int N = Prompt("Enter a number > ");
ShowTillN(N);
