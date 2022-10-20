
/*static bool Exists(char[][] board, string word)
{
    foreach (var row in board)
    {
        for (int i = 0; i < row.Length; i++)
        {
            row[i] = char.ToLower(row[i]);
        }
    }
    return Exists1(board, word, 0, (-1, -1));

}
char[][] board = new char[3][];
board[0] = new char[] { 'A', 'u', 'C', 'E' };
board[1] = new char[] { 'S', 'o', 'C', 'S' };
board[2] = new char[] { 'A', 'Y', 'e', 'E' };
string word = "SEEYou";
System.Console.WriteLine(Exists(board, word));

static bool Exists1(char[][] board, string word, int count, (int, int) currentPos)
{

    if (count == word.Length)
    {
        return true;
    }
    char letter = char.ToLower(word[count]);
    for (int i = 0; i < board.Length; i++)
    {
        for (int j = 0; j < board[0].Length; j++)
        {
            if (board[i][j] == letter)
            {
                if (IsValidMove(board, (i, j), currentPos))
                {
                    board[i][j] = ' ';
                    if (!Exists1(board, word, count + 1, (i, j)))
                    {
                        board[i][j] = word[count];
                    }
                    else
                    {
                        return true;
                    }

                }

            }
        }
    }
    return false;
}

static bool IsValidMove(char[][] board, (int row, int column) pos, (int row, int column) currentPos)
{
    if (currentPos == (-1, -1))
    {
        return true;
    }
    int[] d1 = { 1, -1, 0, 0 };
    int[] d2 = { 0, 0, 1, -1 };
    for (int i = 0; i < d1.Length; i++)
    {
        if (pos == (currentPos.row + d1[i], currentPos.column + d2[i]))
        {
            return true;
        }
    }
    return false;

}*/


char[][] board = new char[3][];
board[0] = new char[] { 'A', 'u', 'C', 'c','t' };
board[1] = new char[] { 'S', 'c', 'H', 'a' ,'e'};
board[2] = new char[] { 'A', 'Y', 'A', 'R' ,'R'};
string word = "chAraccar";
System.Console.WriteLine(Exists(board, word));

static bool Exists(char[][] board, string word)
{
    foreach (var row in board)
    {
        for (int i = 0; i < row.Length; i++)
        {
            row[i] = char.ToLower(row[i]);
        }
    }
    //board solo tiene letras en minusculas
    List<(int,int)> FirstLetterPos = GetFirstLetterPos(board, word);
    foreach (var pos in FirstLetterPos)
    {
        if (Exists1(board, word, 1, pos))
        {
            return true;
        }
    }
    return false;
}

static bool Exists1(char[][] board, string word, int count, (int row, int column) currentPos)
{
    if (count == word.Length)
    {
        return true;
    }
    int[] d1 = { 1, -1, 0, 0 };
    int[] d2 = { 0, 0, 1, -1 };
    for (int i = 0; i < d1.Length; i++)
    {
        (int row,int column) pos = (currentPos.row + d1[i], currentPos.column + d2[i]);
        if (pos.row >= 0 && pos.row < board.Length && pos.column >= 0 && pos.column < board[0].Length && board[pos.row][pos.column] == char.ToLower(word[count]))
        {
            board[pos.row][pos.column] = ' ';
            if (!Exists1(board,word,count+1,pos))
            {
                board[pos.row][pos.column] = word[count];
            }
            else
            {
                return true;
            }
        }
    }

    return false;
}

static List<(int,int)> GetFirstLetterPos(char[][] board, string word)
{
    char letter = char.ToLower(word[0]);
    List<(int,int)> FirstLetterPos = new List<(int,int)>();
    for (int i = 0; i < board.Length; i++)
    {
        for (int j= 0; j < board[0].Length; j++)
        {
            if (board[i][j] == letter)
            {
                FirstLetterPos.Add((i,j));
            }
        }
    }
    return FirstLetterPos;
}
