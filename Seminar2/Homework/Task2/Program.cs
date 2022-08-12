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
  collection[0] = new Random().Next(1,10); //избегаем случая когда у трехзначного числа первая цифра 0
}
int[]array = new int[3]; //создай новый массив с 3 элементами, по умолчанию все нули
FillArray(array); //заменяет нули на цифры
Console.Write($"{array[0]}{array[1]}{array[2]} -> ");
Console.WriteLine($"{array[0]}{array[2]}");
