using System.Text;

namespace Program;
class Program 
{
    static void Main() 
    {
        string a1 = "анаграмма";
        int a1Bytes = Encoding.Unicode.GetByteCount(a1);
        string t = "нагарам";

        HashSet<char> hash2 = new HashSet<char>();
        HashSet<char> hash = new HashSet<char>();
        foreach (var a in a1) {
            hash.Add(a);
        }
        a1 = "";
        foreach (var h in hash) 
        {
            a1 += h;
        }
        foreach (var t1 in t) 
        {
            hash2.Add(t1);
        }
        t = "";
        foreach (var h2 in hash2) 
        {
            t += h2;
        }

        if ((Encoding.Unicode.GetByteCount(t)) == (Encoding.Unicode.GetByteCount(a1))) {
            System.Console.WriteLine("true");
        }
        //не работает...
    }
}