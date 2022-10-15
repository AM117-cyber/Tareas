static List<bool[,]> EightQueens(int n)
{
    List<bool[,]> S = new List<bool[,]>();
    bool[,] solution = new bool[n, n];
    FindSolutions(solution, 0, 0, S);
    return S;
}
EightQueens(3);


static List<bool[,]> FindSolutions(bool[,] solution, int row, int column, List<bool[,]> S)
{
    int lastColumn = solution.GetLength(1) - 1;
    int lastRow = solution.GetLength(0) - 1;

    if (row < lastRow+1)
    {
        solution[row, column] = true;


        if (IsValid(solution, (row, column)))
        {
        
            if (column != lastColumn)
            {
                return FindSolutions(solution, 0, column + 1, S);
            }
            else
            {
                bool[,] s = new bool[solution.GetLength(0),solution.GetLength(0)];
                Array.Copy(solution,s, (int)Math.Pow(lastColumn+1,2));
                S.Add(s);
            }

        }

        solution[row, column] = false;
        if (row != lastRow)
        {
            return FindSolutions(solution, row + 1, column, S);
        }
    }
   if (column == 0)
   {
    return S;
   }
    return FindSolutions(solution, GettingLastQueenRow(solution, column - 1), column - 1, S);

}

static int GettingLastQueenRow(bool[,] solution, int column)
{
    //finding position of last queen to move it a row
    int row = 0;
    for (int i = 0; i < solution.GetLength(0); i++)
    {
        if (solution[i, column])
        {
            solution[i, column] = false;
            row = i + 1;
            return row;

        }
    }
    return row;
}

static bool IsValid(bool[,] a, (int row, int column) pos)
{
    if (pos.column == 0)
    {
        return true;
    }
    //checking same row threats
    for (int i = 0; i < pos.column; i++)
    {
        if (a[pos.row, i])
        {
            return false;
        }
    }

    //checking diagonal threats
    int currentRow = pos.row - 1;
    int currentColumn = pos.column - 1;
    while (currentRow >= 0 && currentColumn >= 0)
    {

        if (a[currentRow--, currentColumn--])
        {
            return false;
        }
    }

    while (pos.row < a.GetLength(0) - 1 && pos.column > 0)
    {
        pos.row++;
        pos.column--;
        if (a[pos.row, pos.column])
        {
            return false;
        }
    }

    return true;

}