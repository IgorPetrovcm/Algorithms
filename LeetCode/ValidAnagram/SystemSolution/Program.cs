namespace SystemSolution;


public class Program
{
    static void Main()
    {
        System.Console.WriteLine(Validate("aab","bba"));
    }

    static bool Validate(string s, string t)
    {
        Array.Sort(s.ToCharArray());
        Array.Sort(t.ToCharArray());

        return Enumerable.SequenceEqual(s,t);
    }
}