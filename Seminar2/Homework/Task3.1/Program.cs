//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}

void ThirdDigit(int Number)
{
  if(Number >99)
  {
    while(Number > 1000)
    {
      Number = Number / 10;
    }
    int result = Number % 10;
    Console.WriteLine($"{result}");
  }
  else
  {
    Console.WriteLine("There is no third digit");
  };
}
int value = Prompt("enter a number > ");
ThirdDigit(value);
