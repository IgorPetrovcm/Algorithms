 namespace Program
{
    using System;
    using System.Buffers;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6};
            int k = 2;
            int trueCount = 0;
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i; j < arr.Length; j++) 
                {
                    if (arr[i] < arr[j]) {
                        trueCount = 0;
                        break;
                    }

                    trueCount++;
                    if (trueCount == k) {
                        Console.Write(arr[i]);
                        return;
                    }
                }
            }
        }
    }
}
