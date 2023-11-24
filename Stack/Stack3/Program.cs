 namespace Program
{
    using System;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            string textFile = @"text.txt";
            Stack<string> stack = new Stack<string>();
            using (var reader = new StreamReader(textFile)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    string regex = @"\w{1,40}";
                    foreach (Match match in Regex.Matches(line,regex)) 
                    {
                        stack.Push(match.Value);
                    }
                }            
            }
            foreach (var r in stack) 
            {
                System.Console.WriteLine(r);
            }
        }
    }
}