// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}

int num = Prompt("Enter a number > ");

if(num % 7 == 0 && num % 23 == 0)
{
  Console.WriteLine($"{num} кратно 7 и 23");
}
else if(num % 7 != 0 && num % 23 != 0)
{
  Console.WriteLine($"{num} не кратно 7 и 23");
}
