// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(1,10);
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

int Sum (int[] a)
{
  int index = 0;
  int length = a.Length;
  int count = 0;
  for(index = 0; index < length; index++)
  {
    if(index % 2 != 0)
    {
      count = count + a[index];
    }
  }
  return count;
}

int[]array = new int[10];
FillArray(array);
PrintArray(array);
int Count = Sum(array);
Console.WriteLine($" -> {Count}");
