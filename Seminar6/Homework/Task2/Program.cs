// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) / 


double Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    double result = double.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

double FindX(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
}
double FindY(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    return y;
}


double b1 = Prompt("Enter b1 > ");
double k1 = Prompt("Enter k1 > ");
double b2 = Prompt("Enter b2 > ");
double k2 = Prompt("Enter k2 > ");
double X = FindX(k1, b1, k2, b2);
double Y = FindY(k1, b1, k2, b2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({X},{Y})");