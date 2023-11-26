 namespace Program
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            string s = "()[]{}";
            Stack<char> stack = new Stack<char>();
            char[] symbols = s.ToCharArray();
            foreach (char c in symbols)
            {
                if (c != '(' && c != '[' && c != '{') 
                {
                    if (stack.Count == 0) {
                        System.Console.WriteLine("false");
                        return;
                    } 
                    if (c == ')' && stack.Peek() == '(') {
                        stack.Pop();
                        continue;
                    }
                    if (c == ']' && stack.Peek() == '[') {
                        stack.Pop();
                        continue;
                    }
                    if (c == '}' && stack.Peek() == '{') {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(c);
            }
            if (stack.Count != 0) System.Console.WriteLine("false");
            else System.Console.WriteLine("true");

        }
    }
}