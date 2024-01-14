namespace SolutionTest;


public class Program
{
    static void Main()
    {
        string s = ",; W;:GlG:;l ;,";

        System.Console.WriteLine(Validate(s));
    }
    public static bool Validate(string s)
    {
        s = s.ToLower();

        int i = -1;
        int j = s.Length;
        while ((j - i) != 1 && (j - i) != 0)
        {
            i++;
            j--; 
            if (i == j) return true;
            if (Char.IsLetter(s[i]) == false && Char.IsDigit(s[i]) == false && Char.IsLetter(s[j]) == false && Char.IsDigit(s[j]) == false)
            {
                while (!Char.IsLetter(s[i]) && !Char.IsDigit(s[i]))
                {
                    i++;
                    if (s.Length - 1 < i) 
                    {
                        i--;
                        break;
                    }
                }
                while (!Char.IsLetter(s[j]) && !Char.IsDigit(s[j]))
                {
                    j--;

                    if (j < 0) 
                    {
                        j++;
                        break;
                    }
                }
            }
            if (s[i] != s[j])
            {
                while (!Char.IsLetter(s[i]) && !Char.IsDigit(s[i]))
                {
                    if (s[i] == s[j]) return true;

                    i++;

                    if (s.Length - 1 < i) 
                    {
                        i--;
                        break;
                    }
                }
                while (!Char.IsLetter(s[j]) && !Char.IsDigit(s[j]))
                {
                    j--;

                    if (j < 0) 
                    {
                        j++;
                        break;
                    }
                }
            }
            if (!(Char.IsLetter(s[i]) || Char.IsDigit(s[i])) && !(Char.IsLetter(s[j]) || Char.IsDigit(s[j]))) return true;

            if (s[i] != s[j]) return false; 
        }
        return true;
    }
}