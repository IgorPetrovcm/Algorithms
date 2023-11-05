 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string socks = "ABABAB";
            string[] arr = new string[socks.Length];
            for (int i = 0; i < arr.Length;i++) 
            {
                arr[i] = socks[i].ToString();
                Console.Write(arr[i]);
            }
            Array.Sort(arr);

            string ost = arr[0];
            int result = 0;
            int count = 1;
            for (int i = 1; i < arr.Length;i++) {
                if (arr[i] != ost) {
                    ost = arr[i];
                    result += count /2;
                    count = 1;
                    continue;
                }
                count++;
            }
            result += count /2;
            Console.WriteLine(result);
        }
    }
}
