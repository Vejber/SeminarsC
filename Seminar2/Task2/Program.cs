// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number = new Random().Next(10,100);
Console.WriteLine($"{number}");
int SecondDigit = number%10;
int FirstDigit = number/10;
Console.WriteLine($"{FirstDigit},{SecondDigit}");
int max = SecondDigit;
if(SecondDigit<FirstDigit)
{
  max = FirstDigit;
}
Console.WriteLine($"max = {max}");
