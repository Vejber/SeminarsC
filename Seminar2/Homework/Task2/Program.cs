// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = new Random().Next(0,10);
    index++;
  }
}
int[]array = new int[3]; //создай новый массив с 3 элементами, по умолчанию все нули
FillArray(array); //заменяет нули на цифры
array[0] = new Random().Next(1,10);
Console.Write($"{array[0]}{array[1]}{array[2]} -> ");
Console.WriteLine($"{array[0]}{array[2]}");
