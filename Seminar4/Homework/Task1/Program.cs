// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
}

int GoExponent(int baza, int exponent) 
{
  int result = 1;
  for (int i = 0; i< exponent; i++)
  {
    result = result * baza;
  }
  return result;
}

int Number1 = Prompt("Enter the base > "); //число
int Number2 = Prompt("Enter a positive exponent > "); //степень
if (Number2 > 0)
{
  int product = GoExponent(Number1, Number2);
  Console.WriteLine($"{Number1} raised to the power of {Number2} = {product}");
};
if (Number2 <=0)
{
  Console.WriteLine("Incorrect exponent");
};
