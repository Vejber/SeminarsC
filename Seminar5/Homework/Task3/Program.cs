// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7.3 22.2 2 78] -> 76

void FillArray(double[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index<length)
  {
    collection[index] = Math.Round(new Random().NextDouble() * new Random().Next(1,1000), 1); // добавляем числа с остатком, указываем сколько цифр после запятой должно быть
    index++;
  }
}
void PrintArray(double[] col) 
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

double min (double[] a)
{
  int index = 0;
  int length = a.Length;
  double minimum = a[0];
  for(index = 0; index < length; index++)
  {
    if(a[index] < minimum)
    {
      minimum = a[index];
    }
  }
  return minimum;
}

double max (double[] a)
{
  int index = 0;
  int length = a.Length;
  double maximum = a[0];
  for(index = 0; index < length; index++)
  {
    if(a[index] > maximum)
    {
      maximum = a[index];
    }
  }
  return maximum;
}

double dif (double arg1, double arg2)
{
  double difference = arg2 - arg1;
  return difference;
}

double[]array = new double[10];
FillArray(array);
PrintArray(array);
double Min = min(array);
double Max = max(array);
double Difference = dif(Min, Max);

Console.WriteLine($" The difference of {Max} and {Min} in the array is {Difference}");
