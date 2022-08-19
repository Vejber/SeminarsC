// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(-9,10);
    index++;
  }
}
void PrintArray(int[] col) //void значит не возвращает значения
{
  int length = col.Length;
  int index = 0;
  Console.Write("["); // для красивого вывода
  while(index<length-1)
  {
    Console.Write($"{col[index]}, "); //для красивого вывода
    index++;
  }
  while(index>length-2 && index < length) // для красивого вывода
  {
    Console.Write($"{col[index]}");
    break;
  }
  Console.Write("]"); // для красивого вывода
}

int SumPositive(int [] arr)
{
  int length = arr.Length;
  int index = 0;
  int summa1 = 0;
  for(index = 0; index < length; index++)
  if (arr[index] >= 0)
  {
    {
      summa1 = summa1 + arr[index];
    }
  }
  return summa1;
}
int SumNegative(int [] arr)
{
  int length = arr.Length;
  int index = 0;
  int summa2 = 0;
  for(index = 0; index < length; index++)
  if (arr[index] < 0)
  {
    {
      summa2 = summa2 + arr[index];
    }
  }
  return summa2;
}

int[]array = new int[12];
FillArray(array);
PrintArray(array);
int sum1 = SumPositive(array);
int sum2 = SumNegative(array);
Console.WriteLine($"In the array the summation of the positive elements = {sum1}, of the negative elements = {sum2}");
