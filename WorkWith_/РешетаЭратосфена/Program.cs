namespace Program;


public class Program
{
    static void Main()
    {
        Algorithm(120);
    }

    public static void Algorithm(int n)
    {
        bool[] s = new bool[n];

        GetPrimeNumbers(s, 1);
    }

    public static void GetPrimeNumbers(bool[] s, int index)
    {
        int firstIndex = index;

        for (int i = index + 1; i < s.Length && index == firstIndex; i++)
        {
            if (s[i] == false)
            {
                index = i;
                Console.WriteLine(index);

                break;
            }
        }

        if (firstIndex == index)
            return;
        
        for (int i = index + 1; i < s.Length; i++)
        {
            if (s[i] == false)
            {
                if (i % index == 0) 
                {
                    s[i] = true;
                }
            }
        }

        GetPrimeNumbers(s, index);
    }
}