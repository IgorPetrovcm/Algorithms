namespace Program 
{
    
    class Program 
    {
        static void Main() 
        {
            int[] temperatures = {73,74,75,71,69,72,76,73};
            int[] output = new int[temperatures.Length];

            Stack<int> stack = new Stack<int>();
            for (int i = temperatures.Length-1; i >= 0; --i) 
            {
                while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()]) stack.Pop();
                if (stack.Count == 0) {
                    output[i] = 0;
                    stack.Push(i);
                    continue;
                }
                output[i] = stack.Peek() - i;
                stack.Push(i);
            }
            foreach (int a in output) System.Console.WriteLine(a);
        }
    }
}