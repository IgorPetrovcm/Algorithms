namespace TestSolution;


public class Program 
{
    static void Main()
    {
        string[] strs = {"eat","tea","tan","ate","nat","bat"};

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
        Dictionary<string,IList<string>> table = new Dictionary<string,IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            char[] hash = new char[26];

            for (int j = 0; j < strs[i].Length; j++)
            {
                hash[strs[i][j] - 'a']++;                    
            }

            string str = new string(hash);

            if (!table.ContainsKey(str))
            {
                table.Add(str, new List<string>(){strs[i]});
            }
            else 
            {
                table[str].Add(strs[i]);
            }
        }

        return table.Values.ToList();
    }
}