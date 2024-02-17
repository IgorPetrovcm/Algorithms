namespace Program;


public class Program
{
    static void Main()
    {
        Algorithm2(120);
    }


    public static void Algorithm2(int n)
    {
        bool[] s = new bool[n];

        s[1] = true;

        for (int i = 2; i * i <= s.Length; i++)
        {
            if (s[i] == false)
            {   
                for (int j = i * i; j < s.Length; j += i)
                {
                    s[j] = true;
                }
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == false)
                System.Console.WriteLine(i);
        }
    }

}