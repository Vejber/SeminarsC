// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

int SumOfDigits(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return SumOfDigits(n / 10) + n % 10;
}

int N = Prompt("Enter a number > ");
int sum = SumOfDigits(N);
Console.WriteLine(sum);


