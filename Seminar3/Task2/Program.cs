// Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).
int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
}

void rangeOfxy(int arg)
{
  if(arg == 1)
  {
    Console.WriteLine("x > 0; y > 0");
  }
  if(arg == 2)
  {
    Console.WriteLine("x < 0; y > 0");
  }
  if(arg == 3)
  {
    Console.WriteLine("x < 0; y < 0");
  }
  if(arg == 4)
  {
    Console.WriteLine("x > 0; y < 0");
  }
  else if (arg < 1 || arg > 4)
  {
    Console.WriteLine("Incorrect number, try again");
  }
};


int quarter = Prompt("Enter a number of a quarter from 1 to 4 > ");
rangeOfxy(quarter);
