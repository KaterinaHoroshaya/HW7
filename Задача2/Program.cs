/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int i = ReadInt("Введите искомую строку: ");
int j = ReadInt("Введите искомый столбец: ");

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
{
    Console.WriteLine(matrix[i, j]);
}
else Console.WriteLine($"Элемента с позициями {i},{j} нет");



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 100);
        }
    }
}