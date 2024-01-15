namespace HashMapSolution;


public class Program
{
    static void  Main()
    {
        System.Console.WriteLine(Validate("anagram","nagaram"));
    }

    static bool Validate(string s, string t)
    {
        if (s.Length < t.Length)
            return false;

        Dictionary<char,int> table = new Dictionary<char, int>();

        for (int i = 0; i < t.Length; i++)
        {
            if (!table.ContainsKey(t[i]))
            {
                table.Add(t[i],1);
            }
            else 
            {
                table[t[i]]++;
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (!table.ContainsKey(s[i]))
                return false;
            else 
            {
                table[s[i]]--;
                if (table[s[i]] < 0)
                    return false;
            }
        }

        return true;
    }
}