using System.Text.RegularExpressions;

namespace Solution1;


public class Program
{
    static void Main()
    {
        string s = "ab_a";

        System.Console.WriteLine(Valid(s));
    }

    static bool Valid(string s)
    {
        s = s.ToLower();

        char[] removeChars = {',','!',' ','_',':','.','@','#','"',']','[','{','}','\\','\'','-','?',';','(',')','`'};

        foreach (char removeChar in removeChars)
        {
            s = s.Replace(removeChar.ToString(), "");
        }
        if (s.Length == 0) return true;
        int i = -1;
        int j = s.Length;
        do 
        {
            i++;
            j--;
            if (s[i] != s[j]) return false;
        }
        while (j - i != 0 && j - i != 1);

        return true;
    }
}