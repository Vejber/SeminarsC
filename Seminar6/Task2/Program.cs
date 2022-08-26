// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

bool IfTriangle(int x, int y, int c)
{
    if (x + y > c && y + c > x && x + c > y)
    {
        return true;
    }
    else 
    {
        return false;
    }
}




int number1 = Prompt("Enter the first number");
int number2 = Prompt("Enter the second number");
int number3 = Prompt("Enter the third number");
bool triangle = IfTriangle(number1, number2, number3);
if(triangle)
{
    Console.WriteLine("Is a triangle");
}
else  
{
    Console.WriteLine("Is not a triangle");
}