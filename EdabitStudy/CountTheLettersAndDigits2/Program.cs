 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "gjj33hjb1h545";
            int letters = 0;
            int digits = 0;

            for (int i = 0; i < txt.Length; i++ ) {
                if (char.IsDigit(txt[i]) == true) {
                    digits++;
                }
                else {
                    letters++;
                }
            } 

            var letdig = new {Letters = letters, Digits = digits};
            Console.WriteLine(letdig.ToString());
        }
    }
}
