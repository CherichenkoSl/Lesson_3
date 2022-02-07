int[,] matrix = { { 23, 431, 654, 72, 56 }, { 12, 65, 87, 98, 90 }, { 2, 22, 255, 879, 122 }, { 43, 23, 77, 12, 0 }, { 33, 260, 55, 279, 120 } };
int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;
int j = 0;
Console.Write("Главная диагональ матрицы: ");
for (int i = 0; i < rows; i++)
{

    while (j < columns)
    {
        Console.Write($"{matrix[i, j]} ");
        break;
    }
    j++;
}
Console.WriteLine();
Console.Write("Побочная диагональ матрицы: ");
int a = 0;
for (int b = columns - 1; b >= 0; b--)
{
    while (a < rows)
    {
        Console.Write($"{matrix[a, b]} ");
        break;
    }
    a++;
}
