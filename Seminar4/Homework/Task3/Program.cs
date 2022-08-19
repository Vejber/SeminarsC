// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
//И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(0,100);
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

int SecondMax(int[] arr)
{
  int max = arr[0];
  int max2 = arr[0];
  int MaxIndex = 0;
  int SecondMaxIndex = 0;
  int length = arr.Length;
  for(MaxIndex = 0; MaxIndex < length; MaxIndex++) //поиск первого максимального
  {
    if(arr[MaxIndex] > max)
    {
      max = arr[MaxIndex];
    }
  }
  for(SecondMaxIndex = 0; SecondMaxIndex < length; SecondMaxIndex++)
  {
    if (arr[SecondMaxIndex] > max2 && arr[SecondMaxIndex] != max)
    {
      max2 = arr[SecondMaxIndex];
    }
  }
return max2;

}

int[]array = new int[8]; // ф-ция создания массива с 8 элементами
FillArray(array);
PrintArray(array);
int second = SecondMax(array);
Console.WriteLine($", {second}");
