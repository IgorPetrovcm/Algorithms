namespace Test;


public class Program
{
    static void Main()
    {
        string s = "abcd";

        char[] hash = new char[26];

        foreach (char c in s)
        {
            hash[c - 'a']++;
        }
    }
}