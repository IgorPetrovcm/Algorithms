namespace Program;
class Program 
{
    static void Main() 
    {
        string s = "анаграмма";
        string t = "нагарам";
                
        HashSet<char> hash = new HashSet<char>(s);
        foreach (var c in hash) 
        {
            System.Console.WriteLine(c);
        } 
        foreach (var c in t) 
        {
            if (!hash.Contains(c)) return;
        }
        System.Console.WriteLine("true");
    }
}