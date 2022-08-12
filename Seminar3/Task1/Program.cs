// Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считавает с консоли строку
  int result = int.Parse(readValue); // Преобрадует строку в целое число
  return result; // Возвращает результат
}
void WhereXY(int arg1, int arg2)
{
  if(arg1>0 && arg2 > 0)
  {
    Console.WriteLine("It's the first square of the space");
  }
  else if(arg1 < 0 && arg2 > 0)
  {
    Console.WriteLine("It's the second square of the space");
  }
  else if(arg1 < 0 && arg2 < 0)
  {
    Console.WriteLine("It's the third square of the space");
  }
  else if(arg1 > 0 && arg2 < 0)
  {
    Console.WriteLine("It's the fourth square of the space");
  }
  else if(arg1 == 0 && arg2 > 0)
  {
    Console.WriteLine("It's either the first or the second square of the space");
  }
  else if(arg1 > 0 && arg2 == 0)
  {
    Console.WriteLine("It's either the first or the fourth square of the space");
  }
  else if(arg1 == 0 && arg2 < 0)
  {
    Console.WriteLine("It's either the third or the fourth square of the space");
  }
  else if(arg1 < 0 && arg2 == 0)
  {
    Console.WriteLine("It's either the second or the third square of the space");
  };
}
int x = Prompt("Enter x > ");
int y = Prompt("Enter y > ");
WhereXY(x,y);
