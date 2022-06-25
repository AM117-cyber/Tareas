
int[,] Matrix1 = {
    {1,2,4,7,2},
    {0,3,-1,3,4},
    {2,-1,6,5,9}
};
int[,] Matrix2 = {
    {2,0},
    {0,3},
    {2,0},
    {8,2},
    {0,0},
};

static int[,] MultiplyMatrix(int[,] Matrix1, int[,] Matrix2){
    int filas = Matrix1.GetLength(0);
    int columns = Matrix2.GetLength(1);
    int[,] result = new int[Matrix1.GetLength(0),Matrix2.GetLength(1)];
    if (Matrix1.GetLength(1) != Matrix2.GetLength(0))
    {
        int[,] impossible = new int[0,0];
        return impossible;
        
    }
    else
    {   
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int value = 0;
                for (int k = 0; k < Matrix1.GetLength(1) ;k++)
                {
                 value += (Matrix1[i,k] * Matrix2[k,j]);
                }
                result[i,j] = value;
            }
        }
    }
    return result;
}

