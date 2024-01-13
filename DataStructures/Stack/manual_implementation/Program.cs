 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            MinStack stack = new MinStack();
            stack.Push(2);
            stack.Push(4);
            stack.Pop();
            System.Console.WriteLine(stack.Top());
        }
    }
}