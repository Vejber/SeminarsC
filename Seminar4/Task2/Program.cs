// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
}

int numDigits(int arg)
{
  int howManyDigits = 1; // из-за типа int
  for(howManyDigits=1; arg/10 !=0; howManyDigits++)
  {
    arg = arg / 10;
  }
  return howManyDigits;
}

int num = Prompt("Enter a number > ");
int digits = numDigits(num);
Console.WriteLine($"Number of digits in number {num} = {digits}");
