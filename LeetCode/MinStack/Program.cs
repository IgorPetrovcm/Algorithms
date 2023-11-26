 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            MinStack stack = new MinStack(); 
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(1);
            System.Console.WriteLine(stack.GetMin());
        }
    }
}
