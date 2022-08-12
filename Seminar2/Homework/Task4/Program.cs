// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}

void DayOff(int Number)
{
  if(Number < 1 || Number > 7)
  {
    Console.WriteLine("Incorrect number, try again");
  }
  else if (Number >=1 && Number <= 5)
  {
    Console.WriteLine("A weekday");
  }
  else if (Number > 5 && Number < 8)
  {
    Console.WriteLine("A weekend day");
  }

}
int value = Prompt("enter a number from 1 to 7 > ");
DayOff(value);
