// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

int n = Prompt("Enter a number");
int result = 1;
if(n>0)
{
  while(result < n+1)
  {
    if(result%2==0)
    {
      System.Console.WriteLine($"{result}");
    }
    result++;
  }
}
if(n<0)
{
  while(result > n)
  {
    if(n%2==0)
    {
      System.Console.WriteLine($"{n}");
    }
    n++;
  }
}
else if(n==0)
{
  System.Console.WriteLine($"{n}");
}
