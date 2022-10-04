static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
{
    return false;
}
char[] s1 = ToOrder(s);
char[] t1 = ToOrder(t);
for (int i = 0; i < s1.Length; i++)
    {
        if (s1[i] != t1[i])
        {
            return false;
        }
    }
    return true;

}

static char[] ToOrder (string a){
    char[] c = a.ToCharArray();
    for (int i = 0; i < c.Length-1; i++)
    {   
        for (int j = i+1; j < c.Length; j++)
        {
           if (c[i] > c[j])
           {
             char copy = c[i];
             c[i] = c[j];
             c[j] = copy;
           }
        }
    }

    return c;
}


System.Console.WriteLine(IsAnagram("abaadagfsytruyfmc   efse","aabadagfsytruyfmc   fsee"));