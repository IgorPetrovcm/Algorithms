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
            }
            if (!(xRev is int)) { Console.Write(0); return; }       
            Console.Write(xRev);
        }
    }
}
