// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5

int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

int a = Prompt("Enter the first number");
int b = Prompt("Enter the second number");
int max = a;
int min = b;
if (b>a)
{
  max = b;
  min = a;
  System.Console.WriteLine($"max = {max}, min = {min}");
}
else if(a>b)
{
  max = a;
  min = b;
  System.Console.WriteLine($"max = {max}, min = {min}");
}
else if(a == b)
{
  System.Console.WriteLine("There is no min or max");
}
