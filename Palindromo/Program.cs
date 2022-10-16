static void IsPalyndrome1(string word)
{

    Console.WriteLine(IsPalyndrome(word, 0, word.Length-1,true,0));
}
IsPalyndrome1("cafsecaseac");
static (bool b, int insertions) IsPalyndrome(string word,int pos1, int pos2,bool b, int insertions)
{   
    if (pos1 >= pos2)
    {
        return (b,insertions);
    }
    if (word[pos1] != word[pos2])
    {
        b = false;
        insertions = insertions+2; 
    }
    
    return IsPalyndrome(word, pos1+1,pos2-1,b,insertions);
}

