// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}

int FirstNumber = Prompt("Enter the first number > ");
int SecondNumber = Prompt("Enter the second number > ");
int ost = FirstNumber % SecondNumber;
if(FirstNumber % SecondNumber == 0)
{
  Console.WriteLine($"{SecondNumber} кратно {FirstNumber}");
}
else if(FirstNumber % SecondNumber != 0)
{
  Console.WriteLine($"{SecondNumber} не кратно {FirstNumber}, остаток = {ost}");
}
