static int GetFrequency(bool[,] interference)
{
    int[] antenas = new int[interference.GetLength(0)];
    return GetFrequency1(interference, antenas, 0,0);
}
bool[,] interference = new bool[9,9];
interference[0,1] = true;
interference[1,0] = true;
interference[1,2] = true;
interference[2,1] = true;
interference[3,2] = true;
interference[2,3] = true;
interference[4,5] = true;
interference[5,4] = true;
interference[6,7] = true;
interference[7,6] = true;
interference[8,6] = true;
interference[6,8] = true;
interference[8,7] = true;
interference[7,8] = true;


System.Console.WriteLine(GetFrequency(interference));
static int GetFrequency1(bool[,] interference, int[] antenas, int antena,int minfreq)
{
    if (antena == antenas.Length)
    {
        return minfreq;
    }
    for (int frequency = 1; frequency < antenas.Length; frequency++)
    {
        if (IsValid(antenas, frequency, antena,interference))
        {
            antenas[antena] = frequency;
            if (frequency > minfreq)
            {
                minfreq = frequency;
            }
            return GetFrequency1(interference, antenas, antena + 1,minfreq);
        }
    }
    return minfreq;
}

static bool IsValid(int[] antenas, int frequency, int antena, bool[,] interference)
{
    for (int i = 0; i < interference.GetLength(0); i++)
    {
        if (interference[antena,i] && antenas[i] == frequency)
        {
            return false;
        }
    }
    return true;
}