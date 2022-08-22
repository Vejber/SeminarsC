// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void TurnArray(int[] col)
{
  int length = col.Length;
  int index = 0;
  for(index = 0; index < length; index++)
  {
    col[index] = -col[index];
  }
  Console.Write("->");
}

int[]array = new int[12];
FillArray(array);
PrintArray(array);
TurnArray(array);
PrintArray(array);
