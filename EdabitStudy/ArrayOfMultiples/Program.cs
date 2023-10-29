namespace Array 
{
    using System;
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input num: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Input arr length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = num * (i+1);
                Console.Write(arr[i] + " ");
            }
            
        }
    }
}