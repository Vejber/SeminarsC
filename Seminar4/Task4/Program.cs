// Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(0,2);
    index++;
  }
}
void PrintArray(int[] col) //void значит не возвращает значения
{
  int length = col.Length;
  int index = 0;
  Console.Write("["); // для красивого вывода
  while(index<length-1) //4 < 5-1
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

int[]array = new int[8]; // ф-ция создания массива с 8 элементами
FillArray(array);
PrintArray(array);
Console.WriteLine();
