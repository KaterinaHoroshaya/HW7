int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int sum = 0;
double sqr = 0;

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

for (columns = 0; columns < matrix.GetLength(1); columns++)
{
    for (rows = 0; rows < matrix.GetLength(0); rows++)
    {
        sum = sum + matrix[rows, columns];
    }
    sqr = sum / rows;
    Console.WriteLine($"Сумма элементов в столбце {columns} равна {sum}, среднее арифметическое равно {sqr}");
    sum = 0;
}

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
