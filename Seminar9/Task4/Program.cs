// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

int Multiply(int a, int b)
{
    if(b == 0)
    {
        return 1;
    }
    
    return Multiply(a, b-1) * a;
    
}

int A = Prompt("Enter number A > ");
int B = Prompt("Enter number B > ");
if(B > 0)
{
int aMultiplyB = Multiply(A, B);
Console.WriteLine(aMultiplyB);
}
else
{
    Console.WriteLine("no");
}