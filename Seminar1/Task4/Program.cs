// Напишите программу вычисления функции:
 // x = f(a)

 int Prompt(string message)
 {
 System.Console.Write(message); // Вывести сообщение
 string readValue = Console.ReadLine(); // Считавает с консоли строку
 int result = int.Parse(readValue); // Преобрадует строку в целое число
 return result; // Возвращает результат
 }

 int a = Prompt("Enter a number");
 int x = a * 7;
 System.Console.WriteLine($"x = {x}");
