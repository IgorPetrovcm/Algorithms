 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1534236469;
            int xRev = 0;
            while (x != 0) 
            {
                int unit = x % 10;
                x /= 10;                
                xRev = xRev * 10 + unit;
                if (xRev % 10 != unit) {Console.Write(0);return;}
            }
            Console.Write(xRev);

            /*int a = 2147483647;
            Console.WriteLine(a.GetType().ToString());
            Console.WriteLine((a+100).GetType().ToString());
            Console.Write(a+100);
            int b = 0;
            if (Int32.TryParse((a + 100).ToString(),out b)) Console.WriteLine("OK");
            Console.WriteLine(b);*/
        }
    }
}
