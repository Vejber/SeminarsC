// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
}

int sum(int arg)
{
  int result = 0;
  for(int i = 0; i <= arg; i++)
  {
    result = result + arg % 10;
    arg = arg / 10;
  }
  return result;
}

int num = Prompt("Enter a number > ");
int summa = 0;
if(num >= 0)
{
  summa = sum(num);
  Console.WriteLine($"The summation of the digits in number {num} results in {summa}");
}
else if(num < 0)
{
  num = num * -1;
  summa = sum(num);
  Console.WriteLine($"The summation of the digits in number -{num} results in {summa}");
}
