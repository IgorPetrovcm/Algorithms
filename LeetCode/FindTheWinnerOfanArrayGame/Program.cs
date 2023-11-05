 namespace Program
{
    using System;
    using System.Buffers;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,1,3,5,4,6,7};
            int k = 2;
            int count = 0;
            int max = arr[0];
            for (int i = 1; i < arr.Length && count != k; i++) 
            {
                if (max < arr[i]) {
                    max = arr[i];
                    count = 1;
                    continue;
                }
                count++;
            }
            Console.WriteLine(max);
        }
    }
}
