/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetMatrix()
{
    int[,] matrix = new int[10, 10];
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

void FindArithmeticMean(int[,] matrix)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {  
        double arithmeticMean = 0;
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {   
            sum += matrix[i, j];
            arithmeticMean = sum / matrix.GetLength(0);
        }
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {Math.Round(arithmeticMean, 2)}");
    }
}

int[,] newMatrix = GetMatrix();
PrintMatrix(newMatrix);
Console.WriteLine();
FindArithmeticMean(newMatrix);