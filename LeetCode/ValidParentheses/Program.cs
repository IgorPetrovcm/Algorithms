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
            string s = "(((()))))";
            Stack<char> stack = new Stack<char>();
            char[] symbols = s.ToCharArray();
            for (int i = 0; i < symbols.Length;i++) 
            {
                if (symbols[i] != '(' || symbols[i] != '[' || symbols[i] != '{') 
                {
                    if (stack.Count == 0) {
                        System.Console.WriteLine("false");
                        return;
                    } 
                    if (symbols[i] == ')') if (stack.Peek() == '(') {
                        stack.Pop();
                        continue;
                    }
                    if (symbols[i] == ']') if (stack.Peek() == '[') {
                        stack.Pop();
                        continue;
                    }
                    if (symbols[i] == '}') if (stack.Peek() == '}') {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(symbols[i]);
            }
            if (stack.Count != 0) System.Console.WriteLine("false");
            else System.Console.WriteLine("true");

        }
    }
}