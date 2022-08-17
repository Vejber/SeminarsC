// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
};
void Square(int arg)
{
  int kvadr = 1;
  while((kvadr*kvadr) <= (arg*arg))
  {
    Console.WriteLine($"{kvadr*kvadr}");
    kvadr++;
  }
};
int N = Prompt("Enter a number > ");
Square(N);
