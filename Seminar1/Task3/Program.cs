//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда
// 5 -> Пятница

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}

int week_number = Prompt("Enter a number from 1 to 7 >");

  if(week_number == 1)
  {
    System.Console.WriteLine("Monday");
  }
  else if(week_number == 2)
  {
    System.Console.WriteLine("Tuesday");
  }
  else if(week_number == 3)
  {
    System.Console.WriteLine("Wednesday");
  }
  else if(week_number == 4)
  {
    System.Console.WriteLine("Thursday");
  }
  else if(week_number == 5)
  {
    System.Console.WriteLine("Friday");
  }
  else if(week_number == 6)
  {
    System.Console.WriteLine("Saturday");
  }
  else if(week_number == 7)
  {
    System.Console.WriteLine("Sunday");
  }
  else
  {
    System.Console.WriteLine("incorrect number, try again"); 
  };
