// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}

int Number = Prompt("enter a three-digit number > ");
int Last = Number%100;
int Middle = Last/10;
Console.WriteLine($"{Middle}");
