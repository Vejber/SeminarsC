// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
};

double space(double arg1, double arg2, double arg3, double arg11, double arg22, double arg33)
{
  double result = Math.Sqrt((arg11-arg1)*(arg11-arg1)+(arg22-arg2)*(arg22-arg2)+(arg33-arg3)*(arg33-arg3));
  return result;
}

double x = Prompt("Enter x > ");
double y = Prompt("Enter y > ");
double q = Prompt("Enter q > ");
double x1 = Prompt("Enter x1 > ");
double y1 = Prompt("Enter y1 > ");
double q1 = Prompt("Enter q1 > ");
double Space = space(x,y,q,x1,y1,q1);
Console.WriteLine($"Space between the points = {Space}");
