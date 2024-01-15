namespace TestSolution;


public class Program
{
    static void Main()
    {
        System.Console.WriteLine(Validate("aacc","ccac"));
    }
    static bool Validate(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char,int> table = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!table.ContainsKey(s[i]))
            {
                table.Add(s[i],1);
            }
            else 
            {
                table[s[i]]++;
            }
        }
        
        Dictionary<char, int> table2 = new Dictionary<char, int>();

        for (int i = 0; i< t.Length; i++)
        {
            if (!table.ContainsKey(t[i]))
                return false;
            else if (!table2.ContainsKey(t[i]))
                table2.Add(t[i],1);
            else 
                table2[t[i]]++;
        }

        foreach (char i in table.Keys)
        {
            if (table[i] != table2[i])
                return false;
        }

        return true;
    }
}