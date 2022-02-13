char[,] cells = new char[10, 10]
{
   {'O','O','X','X','X','O','O','O','O','O' },
   {'X','O','O','O','O','O','O','X','O','O' },
   {'O','O','X','X','O','O','O','X','O','X' },
   {'O','O','O','O','O','O','O','X','O','O' },
   {'O','O','O','O','O','O','O','X','O','O' },
   {'O','X','X','X','O','X','O','O','O','X' },
   {'O','O','O','O','O','O','O','O','O','O' },
   {'X','X','O','X','O','O','O','O','O','O' },
   {'O','O','O','X','O','O','O','O','X','O' },
   {'O','O','O','O','O','O','O','O','X','O' },
};
for(int i=0;i<cells.GetUpperBound(0)+1;i++)
{
    for(int j=0; j<cells.GetUpperBound(1)+1;j++)
    {
        Console.Write($"{cells[i, j]} ");
    }
    Console.WriteLine();
}