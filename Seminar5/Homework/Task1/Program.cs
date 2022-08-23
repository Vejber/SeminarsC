// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(100,1000);
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

int ifEven(int[] a)
{
  int index = 0;
  int length = a.Length;
  int count = 0;
  for(index = 0; index < length; index++)
  {
    if(a[index] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

int[]array = new int[10];
FillArray(array);
PrintArray(array);
int Count = ifEven(array);
Console.WriteLine($" The number of even elements in the array is {Count}");
