static void IsPalyndrome1(string word)
{

    Console.WriteLine(IsPalyndrome(word, 0, word.Length-1,0).ToString());
}
IsPalyndrome1("caseccasac");
static int IsPalyndrome(string word,int pos1, int pos2, int insertions)
{   
    if (pos1 >= pos2)
    {
        return insertions;
    }
    if (word[pos1] != word[pos2])
    {
        
        return Math.Min(IsPalyndrome(word, pos1+1,pos2,insertions+1),IsPalyndrome(word, pos1,pos2-1,insertions+1));
        
    }
    
    return IsPalyndrome(word, pos1+1,pos2-1,insertions);
}

