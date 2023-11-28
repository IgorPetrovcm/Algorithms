using System ;
using System.Text.RegularExpressions;
namespace Program;
class Program 
{

    static void Main() 
    {
        string[] tokens = {"10","6","9","3","+","-11","*","/","*","17","+","5","+"};
        int lengthCount = tokens.Length-1;
        for (int i = 0; i < tokens.Length; i++) 
        {
            if (tokens[i] != "+" && tokens[i] != "-" && tokens[i] != "*" && tokens[i] != "/") continue;
            else 
            {
                int res;
                switch (tokens[i]) 
                {                    
                    case "+": 
                    res = int.Parse(tokens[i-2]) + int.Parse(tokens[i-1]);
                    tokens[i-2] = res.ToString();                    
                    for (int j = i+1; j < tokens.Length; j++) 
                    {
                        tokens[j-2] = tokens[j];
                    }
                    i -= 2;
                    tokens[lengthCount] = "0";
                    tokens[lengthCount - 1] = "0";
                    lengthCount -= 2;
                    break;
                    case "-":
                    res = int.Parse(tokens[i-2]) - int.Parse(tokens[i-1]);
                    tokens[i-2] = res.ToString();
                    for (int j = i+1; j < tokens.Length; j++) 
                    {
                        tokens[j-2] = tokens[j];
                    }
                    i -= 2;
                    tokens[lengthCount] = "0";
                    tokens[lengthCount - 1] = "0";
                    lengthCount -= 2;
                    break;
                    case "*":
                    res = int.Parse(tokens[i-2]) * int.Parse(tokens[i-1]);
                    tokens[i-2] = res.ToString();
                    for (int j = i+1; j < tokens.Length; j++) 
                    {
                        tokens[j-2] = tokens[j];
                    }
                    i -= 2;
                    tokens[lengthCount] = "0";
                    tokens[lengthCount - 1] = "0";
                    lengthCount -= 2;;
                    break;
                    case "/":
                    res = int.Parse(tokens[i-2]) / int.Parse(tokens[i-1]);
                    tokens[i-2] = res.ToString();
                    for (int j = i+1; j < tokens.Length; j++) 
                    {
                        tokens[j-2] = tokens[j];
                    }
                    i -= 2;
                    tokens[lengthCount] = "0";
                    tokens[lengthCount - 1] = "0";
                    lengthCount -= 2;
                    break;
                }                            
            }            
        }
        System.Console.WriteLine(tokens[0]); 
    }
}