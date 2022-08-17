// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
};

//Реверс числа
int NumSplit(int arg)
{
  int result = 0;
  int a1 = arg % 10;
  int a2 = arg / 10 % 10;
  int a3 = arg / 100 % 10;
  int a4 = arg / 1000 % 10;
  int a5 = arg / 10000;
  result = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
  return result;
}

//Проверка на палиндром
bool CheckPalindrom(int value1, int value2)
{
  if (value1 == value2)
  {return true;}
  else
  {return false;}
}

int num1 = Prompt("Enter a five-digit number > ");
if (num1 > 9999 && num1 < 100000) { // проверка на пятизначность
  int num2 = NumSplit(num1);
  bool ifPalindrom = CheckPalindrom(num1, num2);
  if (ifPalindrom)
  {
    Console.WriteLine("Is palindrome");
  }
  else
  {
    Console.WriteLine("Is not palindrome");
  }
}
else
{
  Console.WriteLine("Incorrect number");
}
