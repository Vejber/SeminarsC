// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int [] Turn10to2(int arg)
{
    //int newarg = 0;
    int [] array = new int [10];
    int i = array.Length - 1;
    while(arg>0)
    {
        int newarg = arg % 2;
        arg = arg / 2;
        array[i] = newarg;
        i--;
    }
    return array;
}

int num = Prompt("Enter a number in the decimal numeral system > ");
int [] num10 = Turn10to2(num);

Console.WriteLine($"{num} in the binary numeral system is {(string.Join("", num10))}");
//вывод массива на печать: Console.WriteLine(string.Join(",", array));
