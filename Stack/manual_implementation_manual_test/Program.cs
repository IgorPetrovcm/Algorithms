 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*MinStack stack = new MinStack();
            for (int i = 0; i < 5; i++) 
            {
                stack.Push(i);
            }
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length;i++) 
            {
                arr[i] = stack.Top();
                stack.Pop();            
            }*/

            MinStack stack = new MinStack();
            stack.Push(-2);
            stack.Push(0);
            stack.Push(3);
            stack.Push(-4);
            System.Console.WriteLine(stack.getMin());
        }
    }
}