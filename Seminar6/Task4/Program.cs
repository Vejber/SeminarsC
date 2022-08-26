// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
// формула чисел Фибоначчи 
// f(1) = 1
// f(2) = 1
//f(n) = f(n-1)+f(n-2)

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}

int [] Fibonacci(int n)
{
    int[]array = new int[n];
    array[0] = 0;
    array[1] = 1;
    array[2] = 1;
    int index = 0;
    for(index = 3; index < n; index++)
    {
        array[index] = array [index-1] + array [index-2];
    }
    return array;
}

int num = Prompt("How many Fibonacci numbers do you need? > ");
int [] numFib = Fibonacci(num);

Console.WriteLine($"{num} -> {(string.Join(",", numFib))}");