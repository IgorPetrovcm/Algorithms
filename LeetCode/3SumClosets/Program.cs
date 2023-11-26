 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12,13,14};
            int target = 8;
            int closets = arr[0] + arr[1] + arr[arr.Length-1];
            for (int i = 0; i < arr.Length-2; i++) 
            {
                int j = i+1;
                int k = arr.Length-1;
                while (j < k) 
                {
                    int sum = arr[i] + arr[j] + arr[k];
                    if (sum == target) {Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[k]); return;}
                    if (sum > target) k--; else j++;
                    if (Math.Abs(closets - target) > Math.Abs(sum - target)) closets = sum; 
                }
            }
            Console.WriteLine(closets);
        }
    }
}
