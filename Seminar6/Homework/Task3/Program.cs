// Со Звездочкой (*). Сгенерировать двумерный массив со случайными числами, вывести его на экран, 
//оформить в виде функций (пригодится в дальнейшем)

string[,] table = new string[2, 5]; //Array with strings/words
/*string[,] - тип данных, 
table - название массива, 
2 строки и 5 столбцов */

/* to adress the exact place in array
type its' position (string, bar) by the INDEX*/
// table[1,2] = "word";
// /* to print the table / array:*/
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }





//how to print this array
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//how to fill array with random numbers:
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


//Array with numbers:
int[,] matrix = new int[3, 4];
//PrintArray(matrix);
//Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
