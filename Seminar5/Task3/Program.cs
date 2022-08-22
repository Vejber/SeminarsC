// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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

void FindElement(int[] col, int num)
{
  num = new Random().Next(-9,10);
  int n = col.Length;  //длина массива
  int index = 0; //индекс массива
  while(index<n)
  {
    if(col[index] == num)
    {
      Console.WriteLine($" Found {num}");
      break; //прерывает как только выполняется условие, чтобы не искал вторую семерку
    }
    else
    {
      Console.WriteLine($" Didn't find {num}");
      break;
    }
    index++;
  }
}

int[]array = new int[12];
FillArray(array);
PrintArray(array);
FindElement(array, 0);
