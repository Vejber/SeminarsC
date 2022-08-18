// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int Prompt(string message)
{
  System.Console.Write(message); // Вывести сообщение
  string readValue = Console.ReadLine(); // Считывает с консоли строку
  int result = int.Parse(readValue); // Преобразует строку в целое число
  return result; // Возвращает результат
}

int SumSequence(int arg)
{
  int summa = 0;
  for(int i = 0; i<=arg; i++)
  {
    summa = summa + i;
  }
  return summa;
}

//Другой способ решения по методу Гаусса

int SumGauss(int arg)
{
  int answer = (int)((arg + 1)*(arg / 2.0));
  return answer;
}

int number = Prompt("Enter a number > ");
int sum = SumSequence(number);
Console.WriteLine(sum);
