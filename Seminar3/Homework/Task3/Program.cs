// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
};
void Cube(int arg)
{
  int cube = 1;
  if(arg > 0)
  {
    while((cube*cube*cube) <= (arg*arg*arg))
    {
      Console.WriteLine($"{cube*cube*cube}");
      cube++;
      }}
      else if(arg < 0)
      {
        while((cube*cube*cube) >= (arg*arg*arg))
        {
          Console.WriteLine($"{cube*cube*cube}");
          cube = cube - 1;
        }
      }
    };

int N = Prompt("Enter a number > ");
Cube(N);
