// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

int n = Prompt("Enter a number"); 

if(n>0)
{
  int result = -(n+1);
  while(result != n)
{
  result++;
  System.Console.WriteLine(result);
}
}
if(n<0)
{
  int result = (n-1);
  while(result != -n)
  {
    result++;
    System.Console.WriteLine(result);
  }
}
else if(n == 0)
{
  System.Console.WriteLine($"{n}");
}
