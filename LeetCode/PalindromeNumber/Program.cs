 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int val = 121;
            string a = val.ToString();
            string aReverse = "";
            for (int i = a.Length-1; i > -1; i--) aReverse += a[i];   
                     
            if (aReverse == a) System.Console.WriteLine("true");     
            else System.Console.WriteLine("false");
        }
    }
}
