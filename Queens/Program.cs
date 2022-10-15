static bool EightQueens()
{
    bool[,] a = new bool[8, 8];
    (a, bool b) = GetBoard(a, 0, 0);
    return b;
}
EightQueens();
static (bool[,] a, bool b) GetBoard(bool[,] a, int row, int column)
{
    if (column == 8)
    {
        return (a, true);
    }
    for (int i = 0; i < 8; i++)
    {
        if (IsValid(a, (i, column)))
        {
            a[i, column] = true;
            if (!GetBoard(a, row, column + 1).b)
            {
                a[i, column] = false;
            }
            else
            {
                return (a, true);
            }
        }
    }
    return (a, false);

}

static bool IsValid(bool[,] a, (int row, int column) pos)
{
    int[] vectorForRow = { -1, 0, 1 };
    int rowUp = pos.row;
    int rowDown = pos.row;
    for (int i = pos.column - 1; i >= 0; i--)
    {

        if (a[pos.row, i])
        {
            return false;
        }
        if (rowUp + vectorForRow[0] >= 0 && a[rowUp + vectorForRow[0], i])
        {
            return false;
        }

        if (rowDown + vectorForRow[2] <= 7 && a[rowDown + vectorForRow[2], i])
        {

            return false;
        }
        rowDown++;
        rowUp--;

    }
    return true;
}


