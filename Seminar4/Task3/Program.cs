// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
}

int multi(int arg)// 4
{
  int product = 1;
  if(arg>0)
  {
    for(int i=1; i<=arg; i++)
    {
      product = product*i;
    }
  }
  else if (arg <= 0)
  {
    for(int i=1; i>=arg; i--)
    {
      product = product*i;
    }
  }
  return product;
}

int num = Prompt("Enter a number > ");
int multiplication = multi(num);
Console.WriteLine($"The product of numbers from 1 to {num} = {multiplication}");
