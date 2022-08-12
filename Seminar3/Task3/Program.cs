// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
};


double x = Prompt("Enter x > ");
double y = Prompt("Enter y > ");
double x1 = Prompt("Enter x1 > ");
double y1 = Prompt("Enter y1 > ");
double result = Math.Sqrt((x1-x)*(x1-x)+(y1-y)*(y1-y));
Console.WriteLine($"Space between the points = {result}");
