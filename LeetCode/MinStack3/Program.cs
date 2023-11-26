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
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.GetMin());
        }
    }
}
