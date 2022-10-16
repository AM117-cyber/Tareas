static bool HayRecorrido(int n)
{
    int[,] tablero = new int[n, n];
    tablero[0, 0] = -1;
    return HayRecorrido1(tablero, 0, 0, 1);
}
System.Console.WriteLine(HayRecorrido(8));
static bool HayRecorrido1(int[,] tablero, int row, int column, int step)
{
    int[] vColumn = { 1, -1, 1, -1, 2, 2, -2, -2 };
    int[] vRow = { -2, -2, 2, 2, -1, 1, -1, 1 };
    if (step > tablero.Length - 1)
    {
        return true;
    }

    for (int i = 0; i < 8; i++)
    {

        if (IsValid(tablero, (row + vRow[i], column + vColumn[i])))
        {
            //llenando tablero
            tablero[row + vRow[i], column + vColumn[i]] = step;
            // pasos dados
            if (!HayRecorrido1(tablero, row + vRow[i], column + vColumn[i], step+1))
            {
                tablero[row + vRow[i], column + vColumn[i]] = 0;
            }

        }
    }
    return false;
}

static bool IsValid(int[,] tablero, (int row, int column) pos3)
{
    if ((pos3.row | pos3.column) < 0 | (pos3.row | pos3.column) >= tablero.GetLength(0))
    {
        return false;
    }
    if (tablero[pos3.row, pos3.column] != 0)
    {
        return false;
    }
    return true;
    // mirar dos cosas: que las posiciones esten entre = 0 y tablero.GetLength(0);
    // mirar que tablero en las posiciones sea igual a 0;
}

/*static bool HayRecorrido1(int[,] tablero, int row, int column, int step)
{
    int[] vColumn = { 1, -1, 1, -1, 2, 2, -2, - 2 };
    int[] vRow = { -2, -2, 2, 2, -1, 1, -1, 1 };
    (int row,int column)[] arr = new (int,int)[2];
    if (step >= tablero.Length-1)
    {
        return true;
    }

    for (int i = 0; i < 8; i++)
    {
        if (i < 4)//se mueve por filas
        {
            arr = GetMiddleCells(i, vRow, tablero, row, column);
        }
        else
        {
            arr = GetMiddleCells(i, vColumn, tablero, row, column);
        }

        if (IsValid(tablero, (row+vRow[i], column+vColumn[i]), arr[0], arr[1]))
        {
            //llenando tablero
            tablero[arr[1].row, arr[1].column] = step++;
            tablero[arr[0].row, arr[0].column] = step++;
            tablero[row + vRow[i], column + vColumn[i]] = step++;
            // pasos dados
            if (!HayRecorrido1(tablero, row + vRow[i], column + vColumn[i], step))
            {
                tablero[row + vRow[i], column + vColumn[i]] = 0;
                tablero[arr[1].row, arr[1].column] = 0;
                tablero[arr[0].row, arr[0].column] = 0;
            }

        }
    }
    return false;
}

static (int, int)[] GetMiddleCells(int i, int[] vector, int[,] tablero, int row, int column)
{
    int sign = Math.Sign(vector[i]);
    (int, int)[] arr = new (int, int)[2];
    int j = 0;
    if (i < 4)
    {
        while (j < 2)
        {
            arr[j] = (row + vector[i] - j * sign, column);
            //if (step != 0) step--;
            //tablero[row + vector[i] - j * sign, column] = step;
            j++;
        }

    }
    else
    {
        while (j < 2)
        {
            arr[j] = (row, column + vector[i] - j * sign);
           // if (step != 0) step--;
            //tablero[row, column + vector[i] - j * sign] = step;
            j++;

        }
    }
    return arr;
}
static bool IsValid(int[,] tablero, (int row, int column) pos3, (int row, int column) pos2, (int row, int column) pos1)
{
    if ((pos3.row | pos3.column) < 0 | (pos3.row | pos3.column) >= tablero.GetLength(0))
    {
        return false;
    }
    if (tablero[pos3.row, pos3.column] != 0 || tablero[pos2.row,pos2.column] !=0 || tablero[pos1.row,pos1.column] != 0)
    {
        return false;
    }
    return true;
    // mirar dos cosas: que las posiciones esten entre = 0 y tablero.GetLength(0);
    // mirar que tablero en las posiciones sea igual a 0;
}
*/
