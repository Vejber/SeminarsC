// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> Четное

int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

int n = Prompt("Enter a number > ");
if(n%2==0)
{
  System.Console.WriteLine($"{n} - четное");
}
else
{
  System.Console.WriteLine($"{n} - нечетное");
}
