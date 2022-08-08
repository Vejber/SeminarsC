// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
int Prompt(string message)
{
System.Console.Write(message); // Вывести сообщение
string readValue = Console.ReadLine(); // Считавает с консоли строку
int result = int.Parse(readValue); // Преобрадует строку в целое число
return result; // Возвращает результат
}

int a = Prompt("Enter the first number > ");
int b = Prompt("Enter the second number > ");
int c = Prompt("Enter the third number > ");
int max = a;
if (a == b && b == c)
{
  System.Console.WriteLine("There is no min or max");
}
else if(a == b || a == c || b == c)
{
if (a == b)
{
  if(a>c)
  {
    max = a;
    //System.Console.WriteLine($"max = {max}");
  }
  else if(c>a)
  {
    max = c;
    //System.Console.WriteLine($"max = {max}");
  }
}
else if(b == c)
{
  if(b>a)
  {
    max = b;
    //System.Console.WriteLine($"max = {max}");
  }
  if(a>b)
  {
   max = a;
  //System.Console.WriteLine($"max = {max}");
   }
}
else if(a == c)
{
  if(a>b)
  {
    max = a;
    //System.Console.WriteLine($"max = {max}");
  }
  if(b>a)
  {
    max = b;
    //System.Console.WriteLine($"max = {max}");
  }
}
else if (max<a)
{
  max = a;
  //System.Console.WriteLine($"max = {max}");
 }
}
else if(max<b)
{
  if(c<b)
  {
    max = b;
    //System.Console.WriteLine($"max = {max}");
  }
  else if(b<c)
  {
    max = c;
    //System.Console.WriteLine($"max = {max}");
  }
  System.Console.WriteLine($"max = {max}");
}
System.Console.WriteLine($"max = {max}");
