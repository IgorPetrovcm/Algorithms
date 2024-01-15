using System.Collections;
using System.Runtime.InteropServices;

namespace TestSolution;


public class Program
{
    static void Main()
    {
        System.Console.WriteLine(Valid("anagram","nagaram"));
    }
    static bool Valid(string s, string t)
    {
        if (s.Length != t.Length) 
            return false;

        Hashtable table = new Hashtable();

        for (int i = 0; i < s.Length; i++)
        {
            if (!table.ContainsKey(s[i]))
            {
                table.Add(s[i],1);
            }
            else
            {
                table[s[i]] = (int)table[s[i]] + 1;
            }
        }

        s = null;

        Hashtable table2 = new Hashtable();

        for (int i = 0; i < t.Length; i++)
        {
            if (!table2.ContainsKey(t[i]))
            {
                if (table[t[i]] is null)
                    return false;
                table2.Add(t[i],1);
            }
            else
            {
                table2[t[i]] = (int)table2[t[i]] + 1;
            }
        }

        foreach (object key in table.Keys)
        {
            if ((int)table[key] != (int)table2[key])
                return false;
        }
        
        return true;
    }
}