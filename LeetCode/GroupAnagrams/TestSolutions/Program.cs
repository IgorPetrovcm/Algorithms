namespace TestSolution;


public class Program 
{
    static void Main()
    {
        string[] strs = {"",""};

        foreach (IList<string> strsReadyRead in Anagrams(strs))
        {
            foreach (string item in strsReadyRead)
            {
                System.Console.WriteLine($"{item}, ");
            }
            System.Console.WriteLine("\n");
        }
    }

    static IList<IList<string>> Anagrams(string[] strs)
    {
        Dictionary<char[],List<string>> table = new Dictionary<char[],List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            bool addno = false;

            foreach (char[] key in table.Keys)
            {   
                addno = true;
                if (key.Length == 0)
                {
                    addno = false;

                    break;
                }
                foreach (char c in key)
                {
                    if (!strs[i].Contains(c))
                    {
                        addno = false;

                        break;
                    }
                }
                if (addno)
                {
                    table[key].Add(strs[i]);

                    break; 
                }
            }
            if (!addno)
            {
                if (table.ContainsKey(strs[i].ToCharArray()))
                {
                    table[strs[i].ToCharArray()].Add(strs[i]);
                }
                else
                    table.Add(strs[i].ToCharArray(),new List<string>{strs[i]});
            }
        }

        IList<IList<string>> anagrams = new List<IList<string>>();

        foreach (var value in table.Values)
        {
            anagrams.Add(value);
        }

        return anagrams;
    }
}