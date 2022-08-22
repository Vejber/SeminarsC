// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(1,11);
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

int [] Multiple (int [] a) // работает для массива с четным и нечетным кол-вом элементов
{
  int index = 0;
  int indexMin = 0;
  int length = a.Length;
  int indexMax = length - 1;
  int [] result = new int [(length/2 + length % 2)]; // со всеми нулями, длиной половины начального массива, щас будем заполянть
  for(index = 0, indexMin = 0, indexMax = a.Length - 1; index < length/2+length%2; index++)
  {
    if (indexMin == indexMax)
    {
      result[index] = a[indexMax];
      break;
    }
    else
    {
      result[index] = a[indexMax]*a[indexMin];
      indexMin++;
      indexMax--;
    }

  }
  return result;
}


int[]array = new int[8];
FillArray(array);
PrintArray(array);
array = Multiple(array);
PrintArray(array);
