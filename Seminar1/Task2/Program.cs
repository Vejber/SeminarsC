//  Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = -3 b = 9 -> да

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}

int number = Prompt("Enter the number >");
int square = Prompt("Enter the square >");
if(square / number == number && square % number == 0) // Проверка что валью2 это квадрат валью1
{
  System.Console.WriteLine($"{square} is a square of {number}");
}
else
{
  System.Console.WriteLine($"{square} is not a square of {number}");
}
