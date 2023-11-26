 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            MinStack stack = new MinStack(); 
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);
            System.Console.WriteLine(stack.GetMin());
            stack.Pop();
            System.Console.WriteLine(stack.Top());
            System.Console.WriteLine(stack.GetMin());
        }
    }
}
