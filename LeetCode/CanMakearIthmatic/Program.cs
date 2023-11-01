 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,4,6,3};
            int[] arr2 = {1,4,7};
            int[] arr3 = {6,3,0};

            //O(n)
            int abs = 0;
            if (1 < arr.Length) 
            {
                abs = Math.Abs(arr[0] - arr[1]);
            }

            for (int i = 1; i < arr.Length; i++) 
            {
                if (i+1 < arr.Length) 
                {
                    if (Math.Abs(arr[i] - arr[i+1]) == abs) continue;
                    else { 
                        Console.WriteLine("false"); 
                        return;
                    }
                }
                else break;

            }
            Console.WriteLine("true");
        }
    }
}
