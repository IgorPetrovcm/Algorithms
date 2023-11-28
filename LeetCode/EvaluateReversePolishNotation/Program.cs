using System ;
using System.Text.RegularExpressions;
namespace Program;
class Program 
{

    static void Main() 
    {
        string[] tokens = {"10","6","9","3","+","-11","*","/","*","17","+","5","+"};
        Stack<int> stack = new Stack<int>();
        string regex1 = @"\d";
        for (int i = 0; i < tokens.Length; i++) 
        {
            if (Regex.Matches(tokens[i],regex1).Count > 0) stack.Push(int.Parse(tokens[i]));
            else 
            { 
                int a = stack.Peek();
                stack.Pop();
                int res;
                switch (tokens[i]) 
                {                    
                    case "+": 
                    res = stack.Peek() + a;
                    stack.Pop();
                    stack.Push(res);
                    break;
                    case "-":
                    res = stack.Peek() - a;
                    stack.Pop();
                    stack.Push(res);
                    break;
                    case "*":
                    res = stack.Peek() * a;
                    stack.Pop();
                    stack.Push(res);
                    break;
                    case "/":
                    res = stack.Peek() / a;
                    stack.Pop();
                    stack.Push(res);
                    break;
                } 
            }
        }    
        System.Console.WriteLine(stack.Peek());   
    }
}