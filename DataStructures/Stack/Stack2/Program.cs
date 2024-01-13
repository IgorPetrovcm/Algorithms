using System;
namespace Program 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int sizeArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sizeArr];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < sizeArr; i++ ) 
            {
                stack.Push(i+1);
            }
            for (int i = 0; i < sizeArr; i++ ) 
            {
                arr[i] = stack.Peek();
                System.Console.WriteLine(arr[i]);
                stack.Pop();
            }
        }
    }
}