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
            int winCount = 0;
            while (true) 
            {              
                if (winCount == k) break;  
                if (arr[0] > arr[1]) 
                {
                    winCount++;
                    int unit = arr[1];
                    for (int i = 1; i < arr.Length;i++) 
                    {
                        if (i == arr.Length-1) 
                        {
                            arr[i] = unit;
                            break;
                        }
                        arr[i] = arr[i+1];
                        
                    }
                }
                if (arr[0] < arr[1])
                {
                    winCount = 0;
                    int unit = arr[0];
                    arr[0] = arr[1];
                    for (int i = 1; i < arr.Length;i++) 
                    {
                        if (i == arr.Length-1) 
                        {
                            arr[i] = unit;
                            break;
                        }
                        arr[i] = arr[i+1];
                    }
                }
            }
            Console.Write(arr[0]);
        }
    }
}
