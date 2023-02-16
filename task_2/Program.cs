/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] GetMatrix()
{
    int[,] matrix = new int[5, 5];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        } 
        Console.WriteLine();       
    }
}

void FindNumber(int[,] matrix, int row, int col)
{
    if(row > matrix.GetLength(0) || col > matrix.GetLength(1))
    {
        Console.WriteLine("Числа на данной позиции в массиве нет");
    }
    else
    {
        Console.WriteLine($"{matrix[row - 1, col - 1]}");
    }
}

int[,] matrix = GetMatrix();
PrintMatrix(matrix);
Console.WriteLine("Введите строку");
int rowNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец");
int columnNum = Int32.Parse(Console.ReadLine());
FindNumber(matrix, rowNum, columnNum);